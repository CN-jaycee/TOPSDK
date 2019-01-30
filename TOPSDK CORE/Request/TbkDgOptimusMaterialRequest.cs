using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tbk.dg.optimus.material
    /// </summary>
    public class TbkDgOptimusMaterialRequest : BaseTopRequest<Top.Api.Response.TbkDgOptimusMaterialResponse>
    {
        /// <summary>
        /// mm_xxx_xxx_xxx的第三位
        /// </summary>
        public Nullable<long> AdzoneId { get; set; }

        /// <summary>
        /// 内容详情ID
        /// </summary>
        public Nullable<long> ContentId { get; set; }

        /// <summary>
        /// 内容渠道信息
        /// </summary>
        public string ContentSource { get; set; }

        /// <summary>
        /// 设备号加密类型：MD5
        /// </summary>
        public string DeviceEncrypt { get; set; }

        /// <summary>
        /// 设备号类型：IMEI，或者IDFA，或者UTDID
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备号加密后的值
        /// </summary>
        public string DeviceValue { get; set; }

        /// <summary>
        /// 官方的物料Id(详细物料id见：https://tbk.bbs.taobao.com/detail.html?appId=45301&postId=8576096)
        /// </summary>
        public Nullable<long> MaterialId { get; set; }

        /// <summary>
        /// 第几页，默认：1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.tbk.dg.optimus.material";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adzone_id", this.AdzoneId);
            parameters.Add("content_id", this.ContentId);
            parameters.Add("content_source", this.ContentSource);
            parameters.Add("device_encrypt", this.DeviceEncrypt);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("device_value", this.DeviceValue);
            parameters.Add("material_id", this.MaterialId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("adzone_id", this.AdzoneId);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
