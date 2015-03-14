/**********************************************
 * �����ã�   ��֤ʵ����
 * �����ˣ�   
 * ����ʱ�䣺 2010-09-02 
 ***********************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace LCL
{
    public class ValidateUtils
    {
        #region SQLע��İ�ȫ��֤
        /// <summary>
        /// ����Ƿ���SqlΣ���ַ�
        /// </summary>
        /// <param name="str">Ҫ�ж��ַ���</param>
        /// <returns>�жϽ��</returns>
        public static bool IsSafeSqlString(string str)
        {
            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }

        /// <summary>
        /// �滻sql�������ַ�
        /// </summary>
        /// <param name="str">Ҫ��������ַ���</param>
        /// <returns></returns>
        public static string ReplaceSql(string str)
        {
            string badstr = "and|exec|insert|select|delete|update|count|*|chr|mid|master|truncate|char|declare|set|;|from";

            string[] arraybad = badstr.Split('|');
            for (int i = 0; i < arraybad.Length; i++)
            {
                str = str.Replace(arraybad[i], "");
            }
            return filterSQL(str);
        }

        /// <summary> 
        /// ����SQL,�����漰��������û�ֱ������ĵط���Ҫʹ�á� 
        /// </summary> 
        /// <param name="text">��������</param> 
        /// <returns>���˺���ı�</returns> 
        public static string filterSQL(string text)
        {
            text = text.Replace("'", "''");
            text = text.Replace("{", "{");
            text = text.Replace("}", "}");

            return text;
        }

        /// <summary>
        /// ����Ƿ���Σ�յĿ����������ӵ��ַ���
        /// </summary>
        /// <param name="str">Ҫ�ж��ַ���</param>
        /// <returns>�жϽ��</returns>
        public static bool IsSafeUserInfoString(string str)
        {
            return !Regex.IsMatch(str, @"^\s*$|^c:\\con\\con$|[%,\*" + "\"" + @"\s\t\<\>\&]|�ο�|^Guest");
        }
        #endregion

        #region MyRegion
        /// <summary>
        /// string��ת��Ϊfloat��
        /// </summary>
        /// <param name="strValue">Ҫת�����ַ���</param>
        /// <param name="defValue">ȱʡֵ</param>
        /// <returns>ת�����int���ͽ��</returns>
        public static float StrToFloat(string strValue, float defValue)
        {
            if ((strValue == null) || (strValue.Length > 10))
                return defValue;

            float intValue = defValue;
            if (strValue != null)
            {
                bool IsFloat = Regex.IsMatch(strValue, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsFloat)
                    float.TryParse(strValue, out intValue);
            }
            return intValue;
        }
        /// <summary>
        /// ������ת��ΪInt32����
        /// </summary>
        /// <param name="str">Ҫת�����ַ���</param>
        /// <param name="defValue">ȱʡֵ</param>
        /// <returns>ת�����int���ͽ��</returns>
        public static int StrToInt(string str, int defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length >= 11 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(str, out rv))
                return rv;

            return Convert.ToInt32(StrToFloat(str, defValue));
        }
        #endregion
    }
}
