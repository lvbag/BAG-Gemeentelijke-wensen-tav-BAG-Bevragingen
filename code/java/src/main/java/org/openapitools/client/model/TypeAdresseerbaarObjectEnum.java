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
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Gets or Sets TypeAdresseerbaarObjectEnum
 */
@JsonAdapter(TypeAdresseerbaarObjectEnum.Adapter.class)
public enum TypeAdresseerbaarObjectEnum {
  
  VERBLIJFSOBJECT("verblijfsobject"),
  
  STANDPLAATS("standplaats"),
  
  LIGPLAATS("ligplaats");

  private String value;

  TypeAdresseerbaarObjectEnum(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static TypeAdresseerbaarObjectEnum fromValue(String value) {
    for (TypeAdresseerbaarObjectEnum b : TypeAdresseerbaarObjectEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<TypeAdresseerbaarObjectEnum> {
    @Override
    public void write(final JsonWriter jsonWriter, final TypeAdresseerbaarObjectEnum enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public TypeAdresseerbaarObjectEnum read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return TypeAdresseerbaarObjectEnum.fromValue(value);
    }
  }
}

