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
 * DocGenSettings
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DocGenSettings {
  @SerializedName("language")
  private String language = null;

  @SerializedName("templateRef")
  private ObjectReference templateRef = null;

  @SerializedName("template")
  private DocGenSettingsTemplate template = null;

  @SerializedName("dataRefs")
  private List<ObjectReference> dataRefs = null;

  @SerializedName("datas")
  private List<DocGenSettingsDatas> datas = null;

  @SerializedName("result")
  private DocGenSettingsResult result = null;

  public DocGenSettings language(String language) {
    this.language = language;
    return this;
  }

   /**
   * Get language
   * @return language
  **/
  @ApiModelProperty(value = "")
  public String getLanguage() {
    return language;
  }

  public void setLanguage(String language) {
    this.language = language;
  }

  public DocGenSettings templateRef(ObjectReference templateRef) {
    this.templateRef = templateRef;
    return this;
  }

   /**
   * Get templateRef
   * @return templateRef
  **/
  @ApiModelProperty(value = "")
  public ObjectReference getTemplateRef() {
    return templateRef;
  }

  public void setTemplateRef(ObjectReference templateRef) {
    this.templateRef = templateRef;
  }

  public DocGenSettings template(DocGenSettingsTemplate template) {
    this.template = template;
    return this;
  }

   /**
   * Get template
   * @return template
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsTemplate getTemplate() {
    return template;
  }

  public void setTemplate(DocGenSettingsTemplate template) {
    this.template = template;
  }

  public DocGenSettings dataRefs(List<ObjectReference> dataRefs) {
    this.dataRefs = dataRefs;
    return this;
  }

  public DocGenSettings addDataRefsItem(ObjectReference dataRefsItem) {
    if (this.dataRefs == null) {
      this.dataRefs = new ArrayList<ObjectReference>();
    }
    this.dataRefs.add(dataRefsItem);
    return this;
  }

   /**
   * Get dataRefs
   * @return dataRefs
  **/
  @ApiModelProperty(value = "")
  public List<ObjectReference> getDataRefs() {
    return dataRefs;
  }

  public void setDataRefs(List<ObjectReference> dataRefs) {
    this.dataRefs = dataRefs;
  }

  public DocGenSettings datas(List<DocGenSettingsDatas> datas) {
    this.datas = datas;
    return this;
  }

  public DocGenSettings addDatasItem(DocGenSettingsDatas datasItem) {
    if (this.datas == null) {
      this.datas = new ArrayList<DocGenSettingsDatas>();
    }
    this.datas.add(datasItem);
    return this;
  }

   /**
   * Get datas
   * @return datas
  **/
  @ApiModelProperty(value = "")
  public List<DocGenSettingsDatas> getDatas() {
    return datas;
  }

  public void setDatas(List<DocGenSettingsDatas> datas) {
    this.datas = datas;
  }

  public DocGenSettings result(DocGenSettingsResult result) {
    this.result = result;
    return this;
  }

   /**
   * Get result
   * @return result
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResult getResult() {
    return result;
  }

  public void setResult(DocGenSettingsResult result) {
    this.result = result;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocGenSettings docGenSettings = (DocGenSettings) o;
    return Objects.equals(this.language, docGenSettings.language) &&
        Objects.equals(this.templateRef, docGenSettings.templateRef) &&
        Objects.equals(this.template, docGenSettings.template) &&
        Objects.equals(this.dataRefs, docGenSettings.dataRefs) &&
        Objects.equals(this.datas, docGenSettings.datas) &&
        Objects.equals(this.result, docGenSettings.result);
  }

  @Override
  public int hashCode() {
    return Objects.hash(language, templateRef, template, dataRefs, datas, result);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocGenSettings {\n");
    
    sb.append("    language: ").append(toIndentedString(language)).append("\n");
    sb.append("    templateRef: ").append(toIndentedString(templateRef)).append("\n");
    sb.append("    template: ").append(toIndentedString(template)).append("\n");
    sb.append("    dataRefs: ").append(toIndentedString(dataRefs)).append("\n");
    sb.append("    datas: ").append(toIndentedString(datas)).append("\n");
    sb.append("    result: ").append(toIndentedString(result)).append("\n");
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
