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
import org.openapitools.client.model.HalLink;

/**
 * NummeraanduidingLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-04-16T09:38:40.817877Z[Etc/UTC]")
public class NummeraanduidingLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_ADRES = "adres";
  @SerializedName(SERIALIZED_NAME_ADRES)
  private HalLink adres;

  public static final String SERIALIZED_NAME_OPENBARE_RUIMTE = "openbareRuimte";
  @SerializedName(SERIALIZED_NAME_OPENBARE_RUIMTE)
  private HalLink openbareRuimte;

  public static final String SERIALIZED_NAME_WOONPLAATS = "woonplaats";
  @SerializedName(SERIALIZED_NAME_WOONPLAATS)
  private HalLink woonplaats;


  public NummeraanduidingLinks self(HalLink self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getSelf() {
    return self;
  }


  public void setSelf(HalLink self) {
    this.self = self;
  }


  public NummeraanduidingLinks adres(HalLink adres) {
    
    this.adres = adres;
    return this;
  }

   /**
   * Get adres
   * @return adres
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getAdres() {
    return adres;
  }


  public void setAdres(HalLink adres) {
    this.adres = adres;
  }


  public NummeraanduidingLinks openbareRuimte(HalLink openbareRuimte) {
    
    this.openbareRuimte = openbareRuimte;
    return this;
  }

   /**
   * Get openbareRuimte
   * @return openbareRuimte
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getOpenbareRuimte() {
    return openbareRuimte;
  }


  public void setOpenbareRuimte(HalLink openbareRuimte) {
    this.openbareRuimte = openbareRuimte;
  }


  public NummeraanduidingLinks woonplaats(HalLink woonplaats) {
    
    this.woonplaats = woonplaats;
    return this;
  }

   /**
   * Get woonplaats
   * @return woonplaats
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getWoonplaats() {
    return woonplaats;
  }


  public void setWoonplaats(HalLink woonplaats) {
    this.woonplaats = woonplaats;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NummeraanduidingLinks nummeraanduidingLinks = (NummeraanduidingLinks) o;
    return Objects.equals(this.self, nummeraanduidingLinks.self) &&
        Objects.equals(this.adres, nummeraanduidingLinks.adres) &&
        Objects.equals(this.openbareRuimte, nummeraanduidingLinks.openbareRuimte) &&
        Objects.equals(this.woonplaats, nummeraanduidingLinks.woonplaats);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, adres, openbareRuimte, woonplaats);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NummeraanduidingLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    adres: ").append(toIndentedString(adres)).append("\n");
    sb.append("    openbareRuimte: ").append(toIndentedString(openbareRuimte)).append("\n");
    sb.append("    woonplaats: ").append(toIndentedString(woonplaats)).append("\n");
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

