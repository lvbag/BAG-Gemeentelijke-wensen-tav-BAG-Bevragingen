/*
 * Huidige bevragingen API
 * Deze API levert actuele gegevens over adressen, adresseerbare objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.2.0
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
import org.openapitools.client.model.StatusWoonplaatsEnum;
import org.openapitools.client.model.WoonplaatsMogelijkOnjuist;

/**
 * Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.
 */
@ApiModel(description = "Een woonplaats is een gedeelte van het grondgebied van de gemeente met een naam.")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-08-13T15:19:19.937541Z[Etc/UTC]")
public class Woonplaats {
  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_DOMEIN = "domein";
  @SerializedName(SERIALIZED_NAME_DOMEIN)
  private String domein;

  public static final String SERIALIZED_NAME_NAAM = "naam";
  @SerializedName(SERIALIZED_NAME_NAAM)
  private String naam;

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private StatusWoonplaatsEnum status;

  public static final String SERIALIZED_NAME_GECONSTATEERD = "geconstateerd";
  @SerializedName(SERIALIZED_NAME_GECONSTATEERD)
  private Boolean geconstateerd;

  public static final String SERIALIZED_NAME_DOCUMENTDATUM = "documentdatum";
  @SerializedName(SERIALIZED_NAME_DOCUMENTDATUM)
  private LocalDate documentdatum;

  public static final String SERIALIZED_NAME_DOCUMENTNUMMER = "documentnummer";
  @SerializedName(SERIALIZED_NAME_DOCUMENTNUMMER)
  private String documentnummer;

  public static final String SERIALIZED_NAME_MOGELIJK_ONJUIST = "mogelijkOnjuist";
  @SerializedName(SERIALIZED_NAME_MOGELIJK_ONJUIST)
  private WoonplaatsMogelijkOnjuist mogelijkOnjuist;


  public Woonplaats identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * Get identificatie
   * @return identificatie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public Woonplaats domein(String domein) {
    
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


  public Woonplaats naam(String naam) {
    
    this.naam = naam;
    return this;
  }

   /**
   * De naam van de woonplaats.
   * @return naam
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Duiven", value = "De naam van de woonplaats.")

  public String getNaam() {
    return naam;
  }


  public void setNaam(String naam) {
    this.naam = naam;
  }


  public Woonplaats status(StatusWoonplaatsEnum status) {
    
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public StatusWoonplaatsEnum getStatus() {
    return status;
  }


  public void setStatus(StatusWoonplaatsEnum status) {
    this.status = status;
  }


  public Woonplaats geconstateerd(Boolean geconstateerd) {
    
    this.geconstateerd = geconstateerd;
    return this;
  }

   /**
   * Indicator dat de woonplaats in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. De woonplaats is mogelijk illegaal.
   * @return geconstateerd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Indicator dat de woonplaats in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. De woonplaats is mogelijk illegaal.")

  public Boolean getGeconstateerd() {
    return geconstateerd;
  }


  public void setGeconstateerd(Boolean geconstateerd) {
    this.geconstateerd = geconstateerd;
  }


  public Woonplaats documentdatum(LocalDate documentdatum) {
    
    this.documentdatum = documentdatum;
    return this;
  }

   /**
   * De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.
   * @return documentdatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Mon Feb 09 00:00:00 UTC 2009", value = "De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.")

  public LocalDate getDocumentdatum() {
    return documentdatum;
  }


  public void setDocumentdatum(LocalDate documentdatum) {
    this.documentdatum = documentdatum;
  }


  public Woonplaats documentnummer(String documentnummer) {
    
    this.documentnummer = documentnummer;
    return this;
  }

   /**
   * De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan.
   * @return documentnummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "09.0898", value = "De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegestaan.")

  public String getDocumentnummer() {
    return documentnummer;
  }


  public void setDocumentnummer(String documentnummer) {
    this.documentnummer = documentnummer;
  }


  public Woonplaats mogelijkOnjuist(WoonplaatsMogelijkOnjuist mogelijkOnjuist) {
    
    this.mogelijkOnjuist = mogelijkOnjuist;
    return this;
  }

   /**
   * Get mogelijkOnjuist
   * @return mogelijkOnjuist
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public WoonplaatsMogelijkOnjuist getMogelijkOnjuist() {
    return mogelijkOnjuist;
  }


  public void setMogelijkOnjuist(WoonplaatsMogelijkOnjuist mogelijkOnjuist) {
    this.mogelijkOnjuist = mogelijkOnjuist;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Woonplaats woonplaats = (Woonplaats) o;
    return Objects.equals(this.identificatie, woonplaats.identificatie) &&
        Objects.equals(this.domein, woonplaats.domein) &&
        Objects.equals(this.naam, woonplaats.naam) &&
        Objects.equals(this.status, woonplaats.status) &&
        Objects.equals(this.geconstateerd, woonplaats.geconstateerd) &&
        Objects.equals(this.documentdatum, woonplaats.documentdatum) &&
        Objects.equals(this.documentnummer, woonplaats.documentnummer) &&
        Objects.equals(this.mogelijkOnjuist, woonplaats.mogelijkOnjuist);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identificatie, domein, naam, status, geconstateerd, documentdatum, documentnummer, mogelijkOnjuist);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Woonplaats {\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    domein: ").append(toIndentedString(domein)).append("\n");
    sb.append("    naam: ").append(toIndentedString(naam)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    geconstateerd: ").append(toIndentedString(geconstateerd)).append("\n");
    sb.append("    documentdatum: ").append(toIndentedString(documentdatum)).append("\n");
    sb.append("    documentnummer: ").append(toIndentedString(documentnummer)).append("\n");
    sb.append("    mogelijkOnjuist: ").append(toIndentedString(mogelijkOnjuist)).append("\n");
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

