using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using txtReadWrite.model;

namespace txtReadWrite
{
    /// <summary>
    /// 用户登录
    /// </summary>
    public class Login
    {
        /// <summary>
        /// 登录保存信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool userLogin(UserLogin model)
        {
            bool isSuccess = false;
            var strList = new List<string>();
            strList.Add(model.userName);
            strList.Add(model.userPwd);
            strList.Add(model.isRemPwd==true?"1":"0");
            isSuccess= TxtOperate.TxtWrite(strList);
            return isSuccess;
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <returns></returns>
        public UserLogin GetInfo()
        {
            var re = new UserLogin();
            var result = TxtOperate.TxtRead();
            if(result!=null&&result.Count>0)
            {
                re.userName = result[0];
                re.userPwd = result[1];
                if(result[2]!=null)
                {
                    re.isRemPwd = int.Parse(result[2]) == 1 ? true:false;
                }
            }
            return re;
        }
    }
}
