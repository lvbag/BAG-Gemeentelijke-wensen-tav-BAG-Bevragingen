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

/**
 * uri voor het opvragen van de volgende pagina van deze collectie
 */
@ApiModel(description = "uri voor het opvragen van de volgende pagina van deze collectie")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-04-13T12:21:45.212057Z[Etc/UTC]")
public class HalPaginationLinksAllOfNext {
  public static final String SERIALIZED_NAME_HREF = "href";
  @SerializedName(SERIALIZED_NAME_HREF)
  private String href;

  public static final String SERIALIZED_NAME_TEMPLATED = "templated";
  @SerializedName(SERIALIZED_NAME_TEMPLATED)
  private Boolean templated;

  public static final String SERIALIZED_NAME_TITLE = "title";
  @SerializedName(SERIALIZED_NAME_TITLE)
  private String title;


  public HalPaginationLinksAllOfNext href(String href) {
    
    this.href = href;
    return this;
  }

   /**
   * Get href
   * @return href
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "/resourcenaam?page=5", value = "")

  public String getHref() {
    return href;
  }


  public void setHref(String href) {
    this.href = href;
  }


  public HalPaginationLinksAllOfNext templated(Boolean templated) {
    
    this.templated = templated;
    return this;
  }

   /**
   * Get templated
   * @return templated
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getTemplated() {
    return templated;
  }


  public void setTemplated(Boolean templated) {
    this.templated = templated;
  }


  public HalPaginationLinksAllOfNext title(String title) {
    
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Volgende pagina", value = "")

  public String getTitle() {
    return title;
  }


  public void setTitle(String title) {
    this.title = title;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    HalPaginationLinksAllOfNext halPaginationLinksAllOfNext = (HalPaginationLinksAllOfNext) o;
    return Objects.equals(this.href, halPaginationLinksAllOfNext.href) &&
        Objects.equals(this.templated, halPaginationLinksAllOfNext.templated) &&
        Objects.equals(this.title, halPaginationLinksAllOfNext.title);
  }

  @Override
  public int hashCode() {
    return Objects.hash(href, templated, title);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class HalPaginationLinksAllOfNext {\n");
    sb.append("    href: ").append(toIndentedString(href)).append("\n");
    sb.append("    templated: ").append(toIndentedString(templated)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
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

