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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.AdresHalBasis;
import org.openapitools.client.model.PandHalBasis;

/**
 * AdresseerbaarObjectEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-04-13T12:21:45.212057Z[Etc/UTC]")
public class AdresseerbaarObjectEmbedded {
  public static final String SERIALIZED_NAME_ADRESSEN = "adressen";
  @SerializedName(SERIALIZED_NAME_ADRESSEN)
  private List<AdresHalBasis> adressen = null;

  public static final String SERIALIZED_NAME_PANDEN = "panden";
  @SerializedName(SERIALIZED_NAME_PANDEN)
  private List<PandHalBasis> panden = null;


  public AdresseerbaarObjectEmbedded adressen(List<AdresHalBasis> adressen) {
    
    this.adressen = adressen;
    return this;
  }

  public AdresseerbaarObjectEmbedded addAdressenItem(AdresHalBasis adressenItem) {
    if (this.adressen == null) {
      this.adressen = new ArrayList<>();
    }
    this.adressen.add(adressenItem);
    return this;
  }

   /**
   * Get adressen
   * @return adressen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<AdresHalBasis> getAdressen() {
    return adressen;
  }


  public void setAdressen(List<AdresHalBasis> adressen) {
    this.adressen = adressen;
  }


  public AdresseerbaarObjectEmbedded panden(List<PandHalBasis> panden) {
    
    this.panden = panden;
    return this;
  }

  public AdresseerbaarObjectEmbedded addPandenItem(PandHalBasis pandenItem) {
    if (this.panden == null) {
      this.panden = new ArrayList<>();
    }
    this.panden.add(pandenItem);
    return this;
  }

   /**
   * Get panden
   * @return panden
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<PandHalBasis> getPanden() {
    return panden;
  }


  public void setPanden(List<PandHalBasis> panden) {
    this.panden = panden;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AdresseerbaarObjectEmbedded adresseerbaarObjectEmbedded = (AdresseerbaarObjectEmbedded) o;
    return Objects.equals(this.adressen, adresseerbaarObjectEmbedded.adressen) &&
        Objects.equals(this.panden, adresseerbaarObjectEmbedded.panden);
  }

  @Override
  public int hashCode() {
    return Objects.hash(adressen, panden);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdresseerbaarObjectEmbedded {\n");
    sb.append("    adressen: ").append(toIndentedString(adressen)).append("\n");
    sb.append("    panden: ").append(toIndentedString(panden)).append("\n");
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

