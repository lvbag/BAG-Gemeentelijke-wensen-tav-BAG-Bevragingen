/*
 * Huidige bevragingen API
 * Deze API levert actuele gegevens over adressen, adresseerbare objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.3.0
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
import org.openapitools.client.model.ZoekResultaatHal;

/**
 * ZoekResultaatHalCollectieEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-09-21T08:58:29.540417Z[Etc/UTC]")
public class ZoekResultaatHalCollectieEmbedded {
  public static final String SERIALIZED_NAME_ZOEKRESULTATEN = "zoekresultaten";
  @SerializedName(SERIALIZED_NAME_ZOEKRESULTATEN)
  private List<ZoekResultaatHal> zoekresultaten = null;


  public ZoekResultaatHalCollectieEmbedded zoekresultaten(List<ZoekResultaatHal> zoekresultaten) {
    
    this.zoekresultaten = zoekresultaten;
    return this;
  }

  public ZoekResultaatHalCollectieEmbedded addZoekresultatenItem(ZoekResultaatHal zoekresultatenItem) {
    if (this.zoekresultaten == null) {
      this.zoekresultaten = new ArrayList<>();
    }
    this.zoekresultaten.add(zoekresultatenItem);
    return this;
  }

   /**
   * Get zoekresultaten
   * @return zoekresultaten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<ZoekResultaatHal> getZoekresultaten() {
    return zoekresultaten;
  }


  public void setZoekresultaten(List<ZoekResultaatHal> zoekresultaten) {
    this.zoekresultaten = zoekresultaten;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ZoekResultaatHalCollectieEmbedded zoekResultaatHalCollectieEmbedded = (ZoekResultaatHalCollectieEmbedded) o;
    return Objects.equals(this.zoekresultaten, zoekResultaatHalCollectieEmbedded.zoekresultaten);
  }

  @Override
  public int hashCode() {
    return Objects.hash(zoekresultaten);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ZoekResultaatHalCollectieEmbedded {\n");
    sb.append("    zoekresultaten: ").append(toIndentedString(zoekresultaten)).append("\n");
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

