﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

/*
 * 创建者: 达达
 * 创建时间: 2008-3-12 13:33
 * 版权归属: MaxLabs.
 */

using System;
using System.Reflection;

namespace MaxLabs.WebEngine
{
	/// <summary>
	/// 用于将一个方法标记为模板标签
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class TemplateTagAttribute : TemplateMemberAttribute
	{
		/// <summary>
		/// 从方法上获取自定义标签
		/// </summary>
		/// <param name="method">方法的反射信息</param>
		/// <returns>自定义标签实例，或者null</returns>
		public static TemplateTagAttribute GetFromMethod(MethodInfo method)
		{
			Attribute result = Attribute.GetCustomAttribute(method, typeof(TemplateTagAttribute), true);

			if (result == null)
				return null;

			return (TemplateTagAttribute)result;
		}
	}
}