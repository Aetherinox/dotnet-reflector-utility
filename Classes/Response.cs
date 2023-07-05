using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace ReflectorKG
{
    class Response
    {
        private XslCompiledTransform xslCompiled = new XslCompiledTransform( );
        public Response( )
        {
            XmlDocument xml = new XmlDocument( ) { PreserveWhitespace = true };
            xml.LoadXml("<?xml version='1.0' encoding='utf-8'?>\r<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform' xmlns:msxsl='urn:schemas-microsoft-com:xslt' exclude-result-prefixes='msxsl'>\r  <xsl:output method='xml' indent='no' omit-xml-declaration='yes'/>\r  <xsl:param name='edition'/>\r  <xsl:param name='version'/>\r  <xsl:param name='userspurchased'/>\r  \r  <xsl:template match='activationrequest'>\r    <data>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates/>\r      <edition><xsl:value-of select='$edition'/></edition>\r      <xsl:text>\r</xsl:text>\r      <version><xsl:value-of select='$version'/></version>\r      <xsl:text>\r</xsl:text>\r      <userspurchased><xsl:value-of select='$userspurchased'/></userspurchased>\r      <xsl:text>\r</xsl:text>\r    </data>\r  </xsl:template>\r\r  <xsl:template match='machinehash'>\r    <machinehash>\r      <xsl:value-of select='text( )'/>\r    </machinehash>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='productcode|majorversion|minorversion|serialnumber|session|edition|productname'>\r    <xsl:copy>\r      <xsl:value-of select='text( )'/>\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='productcodes'>\r    <xsl:copy>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates />\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>    \r  </xsl:template>\r\r  <xsl:template match='product'>\r    <xsl:copy>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates />\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='text( )'/>\r</xsl:stylesheet>\r\n");

            xslCompiled.Load(xml);
        }
        public string Generate(string request, string users, string edition)
        {
            XmlDocument document = new XmlDocument( );
            document.LoadXml(request);

            XmlWriterSettings xmlWriterSettings = xslCompiled.OutputSettings.Clone( );
            xmlWriterSettings.NewLineChars = "\r\n";
            xmlWriterSettings.NewLineHandling = NewLineHandling.Replace;

            string v_def_users          = ConfigurationManager.AppSettings["users_min_default"];
            string v_def_version        = ConfigurationManager.AppSettings["version_default"];
            string v_def_edition        = ConfigurationManager.AppSettings["edition_default"];
            string getUsers             = (users == null ? v_def_users : users);
            string getEdition           = (edition == null ? v_def_edition : edition);

            Debug.WriteLine( getUsers );

            XsltArgumentList xsltArgumentList = new XsltArgumentList( );
            xsltArgumentList.AddParam( "version", "", v_def_version);
            xsltArgumentList.AddParam( "edition", "", getEdition);
            xsltArgumentList.AddParam( "userspurchased", "", getUsers );

            StringBuilder sb = new StringBuilder( );
            XmlWriter writer = XmlWriter.Create(sb, xmlWriterSettings);

            xslCompiled.Transform(document, xsltArgumentList, writer);
            string data = sb.ToString( );

            return AddSignature(data);
        }

        private string AddSignature(string data)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters{ Flags = CspProviderFlags.UseMachineKeyStore });
            rsaCryptoServiceProvider.FromXmlString("\r\n<RSAKeyValue>\r\n<Modulus>zLizNmLUd4VlIWee1GXgn/KxEwcghPASQ+NUzZhbY2fTGzpW64T6yEOdHlIbhX1DX6yAz2gMZKfnpQL2aFqxh5ACFV9dONSTzuQzkqeXwFEARsMxGP3eTQSWMpwVhEcraSn1zOqMb3CRDeQpgasq0lv4HRFhbwalOifKarjEL/8=</Modulus>\r\n<Exponent>AQAB</Exponent>\r\n<P>8+4qCwbxpWFuJje/UURm06Uec+Mk6a7Ye9FGvzVlnh7dYK38GR+bnf8NsoMRW8IlJnipfvqqEs1qnhRAJ4j96Q==</P>\r\n<Q>1tnh1UK2FxeVSbTXrrvKlSKAWqkjaQwLB+OQeMM5Ii3ogH++91bmO0Ku8GA4qE+r/KfypT4nECQID7i5ykkFpw==</Q>\r\n<DP>XTEqYtgeTf6xJGy77QJi/ozg24l2OskP8A3+J2LxFb3Y+ey+maKXw38D7qVgZlv/8Xi72MVPYKuWBhraf8A4sQ==</DP>\r\n<DQ>xBAk9FZikQQmahKr2HrqzdmkRBehhtVEo7hZOLr+wmAeklUBUfltNJsPxbApQ/8gtfoVhhIH18Tpzl8GvMCSdQ==</DQ>\r\n<InverseQ>889tPhprihee8OsPUN7Zyf1nH3tNK4uFiGmBCR1l/JMjbK62+wcQxssD7in8dZFzf/hUXZQl++DtiBUtc4O5Tw==</InverseQ>\r\n<D>ZNm0R12GZ17KhBtEzkNl1cW737DKH1MY3GK4GxQsKRszjx09Roba+B7+3rn6HtenghE733DVchyY69w6wQu0mj6fqZ/1ZqvmP0YH1d8otVjG2E6XhshYCJhZ7Ci0Z4n6UZwAG3NBDCtXAqNSUQY7NjPnTfcG5EkQ/nqlFJKdKLE=</D>\r\n</RSAKeyValue>\r\n");

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            string dataBase64 = Convert.ToBase64String(rsaCryptoServiceProvider.SignData(dataBytes, new SHA1CryptoServiceProvider( )));

            return "<activationresponse>\r\n" + data + "\r\n<signature>\r\n" + dataBase64 + "\r\n</signature>\r\n</activationresponse>\r\n";
        }
    }
}
