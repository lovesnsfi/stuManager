using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using DiDaJiangCheng.Common;
using DiDaJiangCheng.Model;
namespace DiDaJiangCheng.BLL
{
    //tbScoreInfo
    public partial class tbScoreInfo
    {

        private readonly DiDaJiangCheng.DAL.tbScoreInfo dal = new DiDaJiangCheng.DAL.tbScoreInfo();
        public tbScoreInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int filedaScoreId)
        {
            return dal.Exists(filedaScoreId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbScoreInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DiDaJiangCheng.Model.tbScoreInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int filedaScoreId)
        {

            return dal.Delete(filedaScoreId);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string filedaScoreIdlist)
        {
            return dal.DeleteList(filedaScoreIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbScoreInfo GetModel(int filedaScoreId)
        {

            return dal.GetModel(filedaScoreId);
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
        public List<DiDaJiangCheng.Model.tbScoreInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbScoreInfo> DataTableToList(DataTable dt)
        {
            List<DiDaJiangCheng.Model.tbScoreInfo> modelList = new List<DiDaJiangCheng.Model.tbScoreInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DiDaJiangCheng.Model.tbScoreInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DiDaJiangCheng.Model.tbScoreInfo();
                    if (dt.Rows[n]["filedaScoreId"].ToString() != "")
                    {
                        model.filedaScoreId = int.Parse(dt.Rows[n]["filedaScoreId"].ToString());
                    }
                    model.filedStuNo = dt.Rows[n]["filedStuNo"].ToString();
                    if (dt.Rows[n]["filedCourseId"].ToString() != "")
                    {
                        model.filedCourseId = int.Parse(dt.Rows[n]["filedCourseId"].ToString());
                    }
                    if (dt.Rows[n]["filedScore"].ToString() != "")
                    {
                        model.filedScore = decimal.Parse(dt.Rows[n]["filedScore"].ToString());
                    }


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


        #region

        /// <summary>
        /// 根据视图ScoreInfo获得数据列表
        /// </summary>
        public DataSet GetListByScoreInfoView(string strWhere)
        {
            return dal.GetListByScoreInfoView(strWhere);
        }
        #endregion

    }
}