<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
				xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
				xmlns:xhtml="http://www.w3.org/1999/xhtml"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt"
				exclude-result-prefixes="msxsl"
>
	<xsl:output method="xml" indent="yes"/>


	<xsl:template match="xhtml:a">

		<!--<xsl:apply-templates select="@* | node()"/>-->
		<xsl:apply-templates></xsl:apply-templates>
	</xsl:template>
	<xsl:template match="a">
		<!--<xsl:copy-of select="."/>-->
		<xsl:apply-templates></xsl:apply-templates>
	</xsl:template>

	<xsl:template match="xhtml:a[starts-with(@href, '/9378000/modules/')]">
		<!--<xsl:copy-of select="."/>-->
		<!--<baz>
			<foo>
				<xsl:number level="any" count="xhtml:a[starts-with(@href, '/9378000/modules/')]" from="/"/>
			</foo>-->
		curl -o Track_<xsl:number level="any" count="xhtml:a[starts-with(@href, '/9378000/modules/')]" from="/"/>.mp3 -L http://www.cve.nl<xsl:value-of select="@href"/>
		<!--</baz>-->
	</xsl:template>



	<xsl:template match="@* | node()">

		<xsl:apply-templates select="@* | node()"/>

	</xsl:template>
</xsl:stylesheet>
