using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maticsoft.DAL
{
       public class SqlWhereClass
    {
        private string _localName;
        private string _javaName;
        private NetOperate _operate;
        private string _value;

        public SqlWhereClass(string localName, string javaName, NetOperate netOperate, string value)
        {
            this._localName = localName;
            this._javaName = javaName;            
            this._operate = netOperate;
            this._value = value;
        }
        public SqlWhereClass()
        {

        }
        public string LocalName
        {
            get { return _localName; }
            set { this._localName = value; }
        }
        public string JavaName
        {
            get { return _javaName; }
            set { this._javaName = value; }
        }
        public NetOperate Operate
        {
            get { return _operate; }
            set { this._operate = value; }
        }
        public string Value
        {
            get { return _value; }
            set { this._value = value; }
        }

        /// <summary>
        /// 转换为单机版参数字符串
        /// </summary>
        /// <returns></returns>
        public string ToLoaclParamString()
        {
            string strResult = "";
            switch (this._operate)
            {
                case NetOperate.EQ:
                    {
                        strResult = string.Format(" {0} = {1} ", LocalName, Value);
                        break;
                    }
                case NetOperate.NEQ:
                    {
                        strResult = string.Format(" {0} <> {1} ", LocalName, Value);
                        break;
                    }
                case NetOperate.LIKE:
                    {
                        strResult = string.Format(" {0} like '%{1}%' ", LocalName, Value.TrimStart('\'').TrimEnd('\''));
                        break;
                    }
                case NetOperate.STARTWITH:
                    {
                        strResult = string.Format(" {0} like '{1}%' ", LocalName, Value.TrimStart('\'').TrimEnd('\''));
                        break;
                    }
                case NetOperate.ENDWITH:
                    {
                        strResult = string.Format(" {0} like '%{1}' ", LocalName, Value.TrimStart('\'').TrimEnd('\''));
                        break;
                    }
                case NetOperate.GT:
                    {
                        strResult = string.Format(" {0} > {1} ", LocalName, Value);
                        break;
                    }
                case NetOperate.LT:
                    {
                        strResult = string.Format(" {0} < {1} ", LocalName, Value);
                        break;
                    }
                case NetOperate.GTE:
                    {
                        strResult = string.Format(" {0} >= {1} ", LocalName, Value);
                        break;
                    }
                case NetOperate.LTE:
                    {
                        strResult = string.Format(" {0} <= {1} ", LocalName, Value);
                        break;
                    }
                case NetOperate.IN:
                    {
                        strResult = string.Format(" {0} in ({1}) ", LocalName, Value);
                        break;
                    }
                case NetOperate.NIN:
                    {
                        strResult = string.Format(" {0} not in ({1}) ", LocalName, Value);
                        break;
                    }
                case NetOperate.ISN:
                    {
                        strResult = string.Format(" {0} is null ", LocalName);
                        break;
                    }
                case NetOperate.ISNN:
                    {
                        strResult = string.Format(" {0} is not null ", LocalName);
                        break;
                    }
            }
            return strResult;
        }

        /// <summary>
        /// 转换为网络版参数字符串
        /// </summary>
        /// <returns></returns>
        public string ToNetParamString()
        {
            string paramValue = Value.TrimStart('\'').TrimEnd('\'');

            if (paramValue.Trim() != "")
                return string.Format("q_{0}_{1}={2}", JavaName, Operate.ToString(), System.Web.HttpUtility.UrlEncode(paramValue));
            else
                return "";
        }
        public string ToNetParamStringNotOp()
        {
            string paramValue = Value.TrimStart('\'').TrimEnd('\'');

            if (paramValue.Trim() != "")
                return string.Format("{0}={1}", JavaName, System.Web.HttpUtility.UrlEncode(paramValue));
            else
                return "";
        }

        /// <summary>
        /// 将list<sqlwhereclass>转换成字符串
        /// </summary>
        /// <param name="lssqlwhere"></param>
        /// <param name="isnet">true网络版，false 单机版</param>
        /// <returns></returns>
        public static string GetListSqlWhereString(List<SqlWhereClass> lstSqlWhereClass, bool isnet)
        {
            StringBuilder sbWhere = new StringBuilder();
            if (lstSqlWhereClass != null && lstSqlWhereClass.Count > 0)
            {
                if (isnet)
                {
                    foreach (SqlWhereClass item in lstSqlWhereClass)
                    {
                        sbWhere.Append(item.ToNetParamString() != "" ? string.Format("{0}&", item.ToNetParamString()) : "");
                    }
                    if (sbWhere.Length > 0)
                        sbWhere.Remove(sbWhere.Length - 1, 1);
                }
                else
                {
                    foreach (SqlWhereClass item in lstSqlWhereClass)
                    {
                        sbWhere.Append(item.ToLoaclParamString() != "" ? string.Format("{0} AND", item.ToLoaclParamString()) : "");
                    }
                    if (sbWhere.Length > 0)
                        sbWhere.Remove(sbWhere.Length - 3, 3);
                }
            }

            return sbWhere.ToString();
        }


        
    }

    /// <summary>
    /// java网络版参数操作符
    /// </summary>
    public enum NetOperate
    {
        /// <summary>
        /// equal pamar
        /// </summary>
        EQ = 0,
        /// <summary>
        /// not equal pamar
        /// </summary>
        NEQ = 1,
        /// <summary>
        /// like '%pamar%'
        /// </summary>
        LIKE = 2,
        /// <summary>
        /// like 'pamar%'
        /// </summary>
        STARTWITH = 3,
        /// <summary>
        /// like '%pamar'
        /// </summary>
        ENDWITH = 4,
        /// <summary>
        /// > pamar
        /// </summary>
        GT = 5,
        /// <summary>
        /// < pamar
        /// </summary>
        LT = 6,
        /// <summary>
        /// >= pamar
        /// </summary>
        GTE = 7,
        /// <summary>
        /// <= pamar
        /// </summary>
        LTE = 8,
        /// <summary>
        /// in (pamar)
        /// </summary>
        IN = 9,
        /// <summary>
        /// not in (pamar)
        /// </summary>
        NIN = 10,
        /// <summary>
        /// pamar is null
        /// </summary>
        ISN = 11,
        /// <summary>
        /// pamar is not null
        /// </summary>
        ISNN = 12,
    }
}

