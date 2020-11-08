<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="html"/>
  <xsl:template match="ScientificSociety">
    <HTML>
      <BODY>
        <BODY>
          <TABLE BORDER="2">
            <TR>
              <TD>
                <b>Ім'я</b>
              </TD>
              <TD>
                <b>Факультет</b>
              </TD>
              <TD>
                <b>Кафедра</b>
              </TD>
              <TD>
                <b>Дата вступу</b>
              </TD>
              <TD>
                <b>Стать</b>
              </TD>
            </TR>
            <xsl:apply-templates select="Member"/>
          </TABLE>
        </BODY>
      </BODY>
    </HTML>
  </xsl:template>
  <xsl:template match="Member">
    <TR>
      <TD>
        <b>
          <xsl:value-of select="@Name"/>
        </b>
      </TD>
      <TD>
        <b>
          <xsl:value-of select="@FcltName"/>
        </b>
      </TD>
      <TD>
        <b>
          <xsl:value-of select="@CthdrName"/>
        </b>
      </TD>
      <TD>
        <b>
          <xsl:value-of select="@TimeOfEntry"/>
        </b>
      </TD>
      <TD>
        <b>
          <xsl:value-of select="@Sex"/>
        </b>
      </TD>
    </TR>
  </xsl:template>
</xsl:stylesheet>
