/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModelProperty;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * DocGenSettingsResultPdfEncryption
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DocGenSettingsResultPdfEncryption {
  /**
   * The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.
   */
  @JsonAdapter(AlgorithmEnum.Adapter.class)
  public enum AlgorithmEnum {
    _128("rc4_128"),
    
    _40("rc4_40");

    private String value;

    AlgorithmEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static AlgorithmEnum fromValue(String text) {
      for (AlgorithmEnum b : AlgorithmEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<AlgorithmEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final AlgorithmEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public AlgorithmEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return AlgorithmEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("algorithm")
  private AlgorithmEnum algorithm = AlgorithmEnum._128;

  @SerializedName("ownerPassword")
  private String ownerPassword = null;

  @SerializedName("userPassword")
  private String userPassword = null;

  /**
   * Gets or Sets permissions
   */
  @JsonAdapter(PermissionsEnum.Adapter.class)
  public enum PermissionsEnum {
    DISALLOWALL("disallowAll"),
    
    ALLOWALL("allowAll"),
    
    CONTENTCOPY("contentCopy"),
    
    CONTENTCOPYFORACCESSIBILITY("contentCopyForAccessibility"),
    
    MODIFYCONTENTS("modifyContents"),
    
    MODIFYANNOTATIONS("modifyAnnotations"),
    
    FILLIN("fillIn"),
    
    DOCUMENTASSEMBLY("documentAssembly"),
    
    PRINTING("printing"),
    
    HIGHRESOLUTIONPRINTING("highResolutionPrinting");

    private String value;

    PermissionsEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static PermissionsEnum fromValue(String text) {
      for (PermissionsEnum b : PermissionsEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<PermissionsEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final PermissionsEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public PermissionsEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return PermissionsEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("permissions")
  private List<PermissionsEnum> permissions = null;

  public DocGenSettingsResultPdfEncryption algorithm(AlgorithmEnum algorithm) {
    this.algorithm = algorithm;
    return this;
  }

   /**
   * The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.
   * @return algorithm
  **/
  @ApiModelProperty(value = "The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.")
  public AlgorithmEnum getAlgorithm() {
    return algorithm;
  }

  public void setAlgorithm(AlgorithmEnum algorithm) {
    this.algorithm = algorithm;
  }

  public DocGenSettingsResultPdfEncryption ownerPassword(String ownerPassword) {
    this.ownerPassword = ownerPassword;
    return this;
  }

   /**
   * The password for the encrypted document
   * @return ownerPassword
  **/
  @ApiModelProperty(value = "The password for the encrypted document")
  public String getOwnerPassword() {
    return ownerPassword;
  }

  public void setOwnerPassword(String ownerPassword) {
    this.ownerPassword = ownerPassword;
  }

  public DocGenSettingsResultPdfEncryption userPassword(String userPassword) {
    this.userPassword = userPassword;
    return this;
  }

   /**
   * The password required for opening the encrypted document
   * @return userPassword
  **/
  @ApiModelProperty(value = "The password required for opening the encrypted document")
  public String getUserPassword() {
    return userPassword;
  }

  public void setUserPassword(String userPassword) {
    this.userPassword = userPassword;
  }

  public DocGenSettingsResultPdfEncryption permissions(List<PermissionsEnum> permissions) {
    this.permissions = permissions;
    return this;
  }

  public DocGenSettingsResultPdfEncryption addPermissionsItem(PermissionsEnum permissionsItem) {
    if (this.permissions == null) {
      this.permissions = new ArrayList<PermissionsEnum>();
    }
    this.permissions.add(permissionsItem);
    return this;
  }

   /**
   * Get permissions
   * @return permissions
  **/
  @ApiModelProperty(value = "")
  public List<PermissionsEnum> getPermissions() {
    return permissions;
  }

  public void setPermissions(List<PermissionsEnum> permissions) {
    this.permissions = permissions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocGenSettingsResultPdfEncryption docGenSettingsResultPdfEncryption = (DocGenSettingsResultPdfEncryption) o;
    return Objects.equals(this.algorithm, docGenSettingsResultPdfEncryption.algorithm) &&
        Objects.equals(this.ownerPassword, docGenSettingsResultPdfEncryption.ownerPassword) &&
        Objects.equals(this.userPassword, docGenSettingsResultPdfEncryption.userPassword) &&
        Objects.equals(this.permissions, docGenSettingsResultPdfEncryption.permissions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(algorithm, ownerPassword, userPassword, permissions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocGenSettingsResultPdfEncryption {\n");
    
    sb.append("    algorithm: ").append(toIndentedString(algorithm)).append("\n");
    sb.append("    ownerPassword: ").append(toIndentedString(ownerPassword)).append("\n");
    sb.append("    userPassword: ").append(toIndentedString(userPassword)).append("\n");
    sb.append("    permissions: ").append(toIndentedString(permissions)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
