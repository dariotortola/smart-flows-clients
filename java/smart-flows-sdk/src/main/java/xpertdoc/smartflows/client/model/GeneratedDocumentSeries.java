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

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * GeneratedDocumentSeries
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class GeneratedDocumentSeries {
  @SerializedName("id")
  private String id = null;

  @SerializedName("header")
  private String header = null;

  @SerializedName("index")
  private Integer index = null;

  @SerializedName("values")
  private List<ChartValue> values = null;

  public GeneratedDocumentSeries id(String id) {
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

  public GeneratedDocumentSeries header(String header) {
    this.header = header;
    return this;
  }

   /**
   * Get header
   * @return header
  **/
  @ApiModelProperty(value = "")
  public String getHeader() {
    return header;
  }

  public void setHeader(String header) {
    this.header = header;
  }

  public GeneratedDocumentSeries index(Integer index) {
    this.index = index;
    return this;
  }

   /**
   * Get index
   * @return index
  **/
  @ApiModelProperty(value = "")
  public Integer getIndex() {
    return index;
  }

  public void setIndex(Integer index) {
    this.index = index;
  }

  public GeneratedDocumentSeries values(List<ChartValue> values) {
    this.values = values;
    return this;
  }

  public GeneratedDocumentSeries addValuesItem(ChartValue valuesItem) {
    if (this.values == null) {
      this.values = new ArrayList<ChartValue>();
    }
    this.values.add(valuesItem);
    return this;
  }

   /**
   * Get values
   * @return values
  **/
  @ApiModelProperty(value = "")
  public List<ChartValue> getValues() {
    return values;
  }

  public void setValues(List<ChartValue> values) {
    this.values = values;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GeneratedDocumentSeries generatedDocumentSeries = (GeneratedDocumentSeries) o;
    return Objects.equals(this.id, generatedDocumentSeries.id) &&
        Objects.equals(this.header, generatedDocumentSeries.header) &&
        Objects.equals(this.index, generatedDocumentSeries.index) &&
        Objects.equals(this.values, generatedDocumentSeries.values);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, header, index, values);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GeneratedDocumentSeries {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    header: ").append(toIndentedString(header)).append("\n");
    sb.append("    index: ").append(toIndentedString(index)).append("\n");
    sb.append("    values: ").append(toIndentedString(values)).append("\n");
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
