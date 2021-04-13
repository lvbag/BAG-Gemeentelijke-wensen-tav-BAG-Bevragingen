/*
 * Huidige bevragingen API
 * Deze API levert actuele gegevens over adressen, adresseerbare objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: bag@kadaster.nl
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.AdresseerbaarObject;
import org.openapitools.client.model.AdresseerbaarObjectHalBasisAllOf;
import org.openapitools.client.model.AdresseerbaarObjectLinks;
import org.openapitools.client.model.AdresseerbaarObjectMogelijkOnjuist;
import org.openapitools.client.model.AdresseerbaarObjectStatusEnum;
import org.openapitools.client.model.GebruiksdoelEnum;
import org.openapitools.client.model.NummeraanduidingIdentificatiesArray;
import org.openapitools.client.model.PuntOfVlak;
import org.openapitools.client.model.TypeAdresseerbaarObjectEnum;

/**
 * AdresseerbaarObjectHalBasis
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-04-13T12:21:45.212057Z[Etc/UTC]")
public class AdresseerbaarObjectHalBasis {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_TYPE = "type";
  @SerializedName(SERIALIZED_NAME_TYPE)
  private TypeAdresseerbaarObjectEnum type;

  public static final String SERIALIZED_NAME_DOCUMENTDATUM = "documentdatum";
  @SerializedName(SERIALIZED_NAME_DOCUMENTDATUM)
  private LocalDate documentdatum;

  public static final String SERIALIZED_NAME_DOCUMENTNUMMER = "documentnummer";
  @SerializedName(SERIALIZED_NAME_DOCUMENTNUMMER)
  private String documentnummer;

  public static final String SERIALIZED_NAME_GEBRUIKSDOELEN = "gebruiksdoelen";
  @SerializedName(SERIALIZED_NAME_GEBRUIKSDOELEN)
  private List<GebruiksdoelEnum> gebruiksdoelen = null;

  public static final String SERIALIZED_NAME_GECONSTATEERD = "geconstateerd";
  @SerializedName(SERIALIZED_NAME_GECONSTATEERD)
  private Boolean geconstateerd;

  public static final String SERIALIZED_NAME_GEOMETRIE = "geometrie";
  @SerializedName(SERIALIZED_NAME_GEOMETRIE)
  private PuntOfVlak geometrie;

  public static final String SERIALIZED_NAME_PAND_IDENTIFICATIES = "pandIdentificaties";
  @SerializedName(SERIALIZED_NAME_PAND_IDENTIFICATIES)
  private List<String> pandIdentificaties = null;

  public static final String SERIALIZED_NAME_NUMMERAANDUIDING_IDENTIFICATIES = "nummeraanduidingIdentificaties";
  @SerializedName(SERIALIZED_NAME_NUMMERAANDUIDING_IDENTIFICATIES)
  private List<NummeraanduidingIdentificatiesArray> nummeraanduidingIdentificaties = null;

  public static final String SERIALIZED_NAME_OPPERVLAKTE = "oppervlakte";
  @SerializedName(SERIALIZED_NAME_OPPERVLAKTE)
  private Integer oppervlakte;

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private AdresseerbaarObjectStatusEnum status;

  public static final String SERIALIZED_NAME_MOGELIJK_ONJUIST = "mogelijkOnjuist";
  @SerializedName(SERIALIZED_NAME_MOGELIJK_ONJUIST)
  private AdresseerbaarObjectMogelijkOnjuist mogelijkOnjuist;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private AdresseerbaarObjectLinks links;


  public AdresseerbaarObjectHalBasis identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * Dit is de identificatie van een verblijfsobject, standplaats of ligplaats.
   * @return identificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "0226010000038820", value = "Dit is de identificatie van een verblijfsobject, standplaats of ligplaats.")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public AdresseerbaarObjectHalBasis domein(String domein) {
    
    this.domein = domein;
    return this;
  }

   /**
   * Het domein waartoe de identificatie behoort.
   * @return domein
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Het domein waartoe de identificatie behoort.")

  public String getDomein() {
    return domein;
  }


  public void setDomein(String domein) {
    this.domein = domein;
  }


  public AdresseerbaarObjectHalBasis type(TypeAdresseerbaarObjectEnum type) {
    
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public TypeAdresseerbaarObjectEnum getType() {
    return type;
  }


  public void setType(TypeAdresseerbaarObjectEnum type) {
    this.type = type;
  }


  public AdresseerbaarObjectHalBasis documentdatum(LocalDate documentdatum) {
    
    this.documentdatum = documentdatum;
    return this;
  }

   /**
   * De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.
   * @return documentdatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Fri Nov 22 00:00:00 UTC 2019", value = "De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.")

  public LocalDate getDocumentdatum() {
    return documentdatum;
  }


  public void setDocumentdatum(LocalDate documentdatum) {
    this.documentdatum = documentdatum;
  }


  public AdresseerbaarObjectHalBasis documentnummer(String documentnummer) {
    
    this.documentnummer = documentnummer;
    return this;
  }

   /**
   * De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan.
   * @return documentnummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "19SZ2048", value = "De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan.")

  public String getDocumentnummer() {
    return documentnummer;
  }


  public void setDocumentnummer(String documentnummer) {
    this.documentnummer = documentnummer;
  }


  public AdresseerbaarObjectHalBasis gebruiksdoelen(List<GebruiksdoelEnum> gebruiksdoelen) {
    
    this.gebruiksdoelen = gebruiksdoelen;
    return this;
  }

  public AdresseerbaarObjectHalBasis addGebruiksdoelenItem(GebruiksdoelEnum gebruiksdoelenItem) {
    if (this.gebruiksdoelen == null) {
      this.gebruiksdoelen = new ArrayList<>();
    }
    this.gebruiksdoelen.add(gebruiksdoelenItem);
    return this;
  }

   /**
   * Get gebruiksdoelen
   * @return gebruiksdoelen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<GebruiksdoelEnum> getGebruiksdoelen() {
    return gebruiksdoelen;
  }


  public void setGebruiksdoelen(List<GebruiksdoelEnum> gebruiksdoelen) {
    this.gebruiksdoelen = gebruiksdoelen;
  }


  public AdresseerbaarObjectHalBasis geconstateerd(Boolean geconstateerd) {
    
    this.geconstateerd = geconstateerd;
    return this;
  }

   /**
   * Indicatie dat een standplaats, ligplaats of verblijfsobject in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. Het adresseerbaar object is mogelijk illegaal.
   * @return geconstateerd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Indicatie dat een standplaats, ligplaats of verblijfsobject in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. Het adresseerbaar object is mogelijk illegaal.")

  public Boolean getGeconstateerd() {
    return geconstateerd;
  }


  public void setGeconstateerd(Boolean geconstateerd) {
    this.geconstateerd = geconstateerd;
  }


  public AdresseerbaarObjectHalBasis geometrie(PuntOfVlak geometrie) {
    
    this.geometrie = geometrie;
    return this;
  }

   /**
   * Get geometrie
   * @return geometrie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PuntOfVlak getGeometrie() {
    return geometrie;
  }


  public void setGeometrie(PuntOfVlak geometrie) {
    this.geometrie = geometrie;
  }


  public AdresseerbaarObjectHalBasis pandIdentificaties(List<String> pandIdentificaties) {
    
    this.pandIdentificaties = pandIdentificaties;
    return this;
  }

  public AdresseerbaarObjectHalBasis addPandIdentificatiesItem(String pandIdentificatiesItem) {
    if (this.pandIdentificaties == null) {
      this.pandIdentificaties = new ArrayList<>();
    }
    this.pandIdentificaties.add(pandIdentificatiesItem);
    return this;
  }

   /**
   * Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is.
   * @return pandIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is.")

  public List<String> getPandIdentificaties() {
    return pandIdentificaties;
  }


  public void setPandIdentificaties(List<String> pandIdentificaties) {
    this.pandIdentificaties = pandIdentificaties;
  }


  public AdresseerbaarObjectHalBasis nummeraanduidingIdentificaties(List<NummeraanduidingIdentificatiesArray> nummeraanduidingIdentificaties) {
    
    this.nummeraanduidingIdentificaties = nummeraanduidingIdentificaties;
    return this;
  }

  public AdresseerbaarObjectHalBasis addNummeraanduidingIdentificatiesItem(NummeraanduidingIdentificatiesArray nummeraanduidingIdentificatiesItem) {
    if (this.nummeraanduidingIdentificaties == null) {
      this.nummeraanduidingIdentificaties = new ArrayList<>();
    }
    this.nummeraanduidingIdentificaties.add(nummeraanduidingIdentificatiesItem);
    return this;
  }

   /**
   * Identificatie(s) van de hoofd- en nevenadressen van de standplaats, ligplaats of verblijfsobject.
   * @return nummeraanduidingIdentificaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Identificatie(s) van de hoofd- en nevenadressen van de standplaats, ligplaats of verblijfsobject.")

  public List<NummeraanduidingIdentificatiesArray> getNummeraanduidingIdentificaties() {
    return nummeraanduidingIdentificaties;
  }


  public void setNummeraanduidingIdentificaties(List<NummeraanduidingIdentificatiesArray> nummeraanduidingIdentificaties) {
    this.nummeraanduidingIdentificaties = nummeraanduidingIdentificaties;
  }


  public AdresseerbaarObjectHalBasis oppervlakte(Integer oppervlakte) {
    
    this.oppervlakte = oppervlakte;
    return this;
  }

   /**
   * Get oppervlakte
   * @return oppervlakte
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getOppervlakte() {
    return oppervlakte;
  }


  public void setOppervlakte(Integer oppervlakte) {
    this.oppervlakte = oppervlakte;
  }


  public AdresseerbaarObjectHalBasis status(AdresseerbaarObjectStatusEnum status) {
    
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AdresseerbaarObjectStatusEnum getStatus() {
    return status;
  }


  public void setStatus(AdresseerbaarObjectStatusEnum status) {
    this.status = status;
  }


  public AdresseerbaarObjectHalBasis mogelijkOnjuist(AdresseerbaarObjectMogelijkOnjuist mogelijkOnjuist) {
    
    this.mogelijkOnjuist = mogelijkOnjuist;
    return this;
  }

   /**
   * Get mogelijkOnjuist
   * @return mogelijkOnjuist
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AdresseerbaarObjectMogelijkOnjuist getMogelijkOnjuist() {
    return mogelijkOnjuist;
  }


  public void setMogelijkOnjuist(AdresseerbaarObjectMogelijkOnjuist mogelijkOnjuist) {
    this.mogelijkOnjuist = mogelijkOnjuist;
  }


  public AdresseerbaarObjectHalBasis links(AdresseerbaarObjectLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AdresseerbaarObjectLinks getLinks() {
    return links;
  }


  public void setLinks(AdresseerbaarObjectLinks links) {
    this.links = links;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AdresseerbaarObjectHalBasis adresseerbaarObjectHalBasis = (AdresseerbaarObjectHalBasis) o;
    return Objects.equals(this.identificatie, adresseerbaarObjectHalBasis.identificatie) &&
        Objects.equals(this.domein, adresseerbaarObjectHalBasis.domein) &&
        Objects.equals(this.type, adresseerbaarObjectHalBasis.type) &&
        Objects.equals(this.documentdatum, adresseerbaarObjectHalBasis.documentdatum) &&
        Objects.equals(this.documentnummer, adresseerbaarObjectHalBasis.documentnummer) &&
        Objects.equals(this.gebruiksdoelen, adresseerbaarObjectHalBasis.gebruiksdoelen) &&
        Objects.equals(this.geconstateerd, adresseerbaarObjectHalBasis.geconstateerd) &&
        Objects.equals(this.geometrie, adresseerbaarObjectHalBasis.geometrie) &&
        Objects.equals(this.pandIdentificaties, adresseerbaarObjectHalBasis.pandIdentificaties) &&
        Objects.equals(this.nummeraanduidingIdentificaties, adresseerbaarObjectHalBasis.nummeraanduidingIdentificaties) &&
        Objects.equals(this.oppervlakte, adresseerbaarObjectHalBasis.oppervlakte) &&
        Objects.equals(this.status, adresseerbaarObjectHalBasis.status) &&
        Objects.equals(this.mogelijkOnjuist, adresseerbaarObjectHalBasis.mogelijkOnjuist) &&
        Objects.equals(this.links, adresseerbaarObjectHalBasis.links);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, type, documentdatum, documentnummer, gebruiksdoelen, geconstateerd, geometrie, pandIdentificaties, nummeraanduidingIdentificaties, oppervlakte, status, mogelijkOnjuist, links);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdresseerbaarObjectHalBasis {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    documentdatum: ").append(toIndentedString(documentdatum)).append("\n");
    sb.append("    documentnummer: ").append(toIndentedString(documentnummer)).append("\n");
    sb.append("    gebruiksdoelen: ").append(toIndentedString(gebruiksdoelen)).append("\n");
    sb.append("    geconstateerd: ").append(toIndentedString(geconstateerd)).append("\n");
    sb.append("    geometrie: ").append(toIndentedString(geometrie)).append("\n");
    sb.append("    pandIdentificaties: ").append(toIndentedString(pandIdentificaties)).append("\n");
    sb.append("    nummeraanduidingIdentificaties: ").append(toIndentedString(nummeraanduidingIdentificaties)).append("\n");
    sb.append("    oppervlakte: ").append(toIndentedString(oppervlakte)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    mogelijkOnjuist: ").append(toIndentedString(mogelijkOnjuist)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

