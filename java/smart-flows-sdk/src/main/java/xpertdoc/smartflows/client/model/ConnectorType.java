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

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.Objects;

/**
 * ConnectorType
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ConnectorType {
  @SerializedName("id")
  private String id = null;

  @SerializedName("displayName")
  private String displayName = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("javaType")
  private String javaType = null;

  @SerializedName("readSchema")
  private Object readSchema = null;

  @SerializedName("writeSchema")
  private Object writeSchema = null;

  @SerializedName("resourceFetch")
  private ConnectorTypeResourceFetch resourceFetch = null;

  public ConnectorType id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public ConnectorType displayName(String displayName) {
    this.displayName = displayName;
    return this;
  }

   /**
   * Get displayName
   * @return displayName
  **/
  @ApiModelProperty(required = true, value = "")
  public String getDisplayName() {
    return displayName;
  }

  public void setDisplayName(String displayName) {
    this.displayName = displayName;
  }

  public ConnectorType description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public ConnectorType javaType(String javaType) {
    this.javaType = javaType;
    return this;
  }

   /**
   * Get javaType
   * @return javaType
  **/
  @ApiModelProperty(value = "")
  public String getJavaType() {
    return javaType;
  }

  public void setJavaType(String javaType) {
    this.javaType = javaType;
  }

  public ConnectorType readSchema(Object readSchema) {
    this.readSchema = readSchema;
    return this;
  }

   /**
   * Get readSchema
   * @return readSchema
  **/
  @ApiModelProperty(value = "")
  public Object getReadSchema() {
    return readSchema;
  }

  public void setReadSchema(Object readSchema) {
    this.readSchema = readSchema;
  }

  public ConnectorType writeSchema(Object writeSchema) {
    this.writeSchema = writeSchema;
    return this;
  }

   /**
   * Get writeSchema
   * @return writeSchema
  **/
  @ApiModelProperty(value = "")
  public Object getWriteSchema() {
    return writeSchema;
  }

  public void setWriteSchema(Object writeSchema) {
    this.writeSchema = writeSchema;
  }

  public ConnectorType resourceFetch(ConnectorTypeResourceFetch resourceFetch) {
    this.resourceFetch = resourceFetch;
    return this;
  }

   /**
   * Get resourceFetch
   * @return resourceFetch
  **/
  @ApiModelProperty(value = "")
  public ConnectorTypeResourceFetch getResourceFetch() {
    return resourceFetch;
  }

  public void setResourceFetch(ConnectorTypeResourceFetch resourceFetch) {
    this.resourceFetch = resourceFetch;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ConnectorType connectorType = (ConnectorType) o;
    return Objects.equals(this.id, connectorType.id) &&
        Objects.equals(this.displayName, connectorType.displayName) &&
        Objects.equals(this.description, connectorType.description) &&
        Objects.equals(this.javaType, connectorType.javaType) &&
        Objects.equals(this.readSchema, connectorType.readSchema) &&
        Objects.equals(this.writeSchema, connectorType.writeSchema) &&
        Objects.equals(this.resourceFetch, connectorType.resourceFetch);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, displayName, description, javaType, readSchema, writeSchema, resourceFetch);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConnectorType {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    displayName: ").append(toIndentedString(displayName)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    javaType: ").append(toIndentedString(javaType)).append("\n");
    sb.append("    readSchema: ").append(toIndentedString(readSchema)).append("\n");
    sb.append("    writeSchema: ").append(toIndentedString(writeSchema)).append("\n");
    sb.append("    resourceFetch: ").append(toIndentedString(resourceFetch)).append("\n");
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
