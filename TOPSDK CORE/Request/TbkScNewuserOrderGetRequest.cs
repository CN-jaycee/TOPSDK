using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tbk.sc.newuser.order.get
    /// </summary>
    public class TbkScNewuserOrderGetRequest : BaseTopRequest<Top.Api.Response.TbkScNewuserOrderGetResponse>
    {
        /// <summary>
        /// 活动id， 现有活动id包括： 2月手淘拉新：119013_2 3月手淘拉新：119013_3 4月手淘拉新：119013_4 拉手机支付宝新用户_赚赏金：200000_5
        /// </summary>
        public string ActivityId { get; set; }

        /// <summary>
        /// mm_xxx_xxx_xxx的第三位
        /// </summary>
        public Nullable<long> AdzoneId { get; set; }

        /// <summary>
        /// 结束时间，当活动为淘宝活动，表示最晚结束时间；当活动为支付宝活动，表示最晚绑定时间；当活动为天猫活动，表示最晚领取红包的时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// mm_xxx_xxx_xxx的第二位
        /// </summary>
        public Nullable<long> SiteId { get; set; }

        /// <summary>
        /// 开始时间，当活动为淘宝活动，表示最早注册时间；当活动为支付宝活动，表示最早绑定时间；当活动为天猫活动，表示最早领取红包时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.tbk.sc.newuser.order.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_id", this.ActivityId);
            parameters.Add("adzone_id", this.AdzoneId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("site_id", this.SiteId);
            parameters.Add("start_time", this.StartTime);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
        }

        #endregion
    }
}
