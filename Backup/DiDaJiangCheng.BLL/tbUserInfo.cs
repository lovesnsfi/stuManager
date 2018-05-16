using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using DiDaJiangCheng.Common;
using DiDaJiangCheng.Model;
namespace DiDaJiangCheng.BLL
{
    //tbUserInfo
    public partial class tbUserInfo
    {

        private readonly DiDaJiangCheng.DAL.tbUserInfo dal = new DiDaJiangCheng.DAL.tbUserInfo();
        public tbUserInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string UserName)
        {
            return dal.Exists(UserName);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbUserInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DiDaJiangCheng.Model.tbUserInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int UserId)
        {

            return dal.Delete(UserId);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string UserIdlist)
        {
            return dal.DeleteList(UserIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbUserInfo GetModel(int UserId)
        {

            return dal.GetModel(UserId);
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbUserInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbUserInfo> DataTableToList(DataTable dt)
        {
            List<DiDaJiangCheng.Model.tbUserInfo> modelList = new List<DiDaJiangCheng.Model.tbUserInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DiDaJiangCheng.Model.tbUserInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DiDaJiangCheng.Model.tbUserInfo();
                    if (dt.Rows[n]["UserId"].ToString() != "")
                    {
                        model.UserId = int.Parse(dt.Rows[n]["UserId"].ToString());
                    }
                    model.UserName = dt.Rows[n]["UserName"].ToString();
                    model.UserPassword = dt.Rows[n]["UserPassword"].ToString();


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion


        #region  ExtendMethod

        /// <summary>
        /// 登陆方法
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="PassWord">密码</param>
        /// <returns></returns>
        public DataTable CheckLogin(string UserName, string PassWord)
        {
            return dal.CheckLogin(UserName, PassWord);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbUserInfo GetModel(string UserName)
        {
            return dal.GetModel(UserName);
        }
        #endregion

    }
}