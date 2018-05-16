using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using DiDaJiangCheng.Common;
using DiDaJiangCheng.Model;
namespace DiDaJiangCheng.BLL
{
    //tbClassInfo
    public partial class tbClassInfo
    {

        private readonly DiDaJiangCheng.DAL.tbClassInfo dal = new DiDaJiangCheng.DAL.tbClassInfo();
        public tbClassInfo()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ClassId)
        {
            return dal.Exists(ClassId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DiDaJiangCheng.Model.tbClassInfo model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DiDaJiangCheng.Model.tbClassInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ClassId)
        {

            return dal.Delete(ClassId);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string ClassIdlist)
        {
            return dal.DeleteList(ClassIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DiDaJiangCheng.Model.tbClassInfo GetModel(int ClassId)
        {

            return dal.GetModel(ClassId);
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
        public List<DiDaJiangCheng.Model.tbClassInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DiDaJiangCheng.Model.tbClassInfo> DataTableToList(DataTable dt)
        {
            List<DiDaJiangCheng.Model.tbClassInfo> modelList = new List<DiDaJiangCheng.Model.tbClassInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DiDaJiangCheng.Model.tbClassInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DiDaJiangCheng.Model.tbClassInfo();
                    if (dt.Rows[n]["ClassId"].ToString() != "")
                    {
                        model.ClassId = int.Parse(dt.Rows[n]["ClassId"].ToString());
                    }
                    model.ClassName = dt.Rows[n]["ClassName"].ToString();
                    if (dt.Rows[n]["SpecialtyId"].ToString() != "")
                    {
                        model.SpecialtyId = int.Parse(dt.Rows[n]["SpecialtyId"].ToString());
                    }
                    model.classroomId = dt.Rows[n]["classroomId"].ToString();
                    model.eductionalSystem = dt.Rows[n]["eductionalSystem"].ToString();
                    if (dt.Rows[n]["enterTime"].ToString() != "")
                    {
                        model.enterTime = DateTime.Parse(dt.Rows[n]["enterTime"].ToString());
                    }
                    model.Marks = dt.Rows[n]["Marks"].ToString();


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



        #region ExpendMethod
         /// <summary>
        /// 根据视图ClassInfoView获得数据列表
        /// </summary>
        public DataSet GetListByClassInfoView(string strWhere)
        {
            return dal.GetListByClassInfoView(strWhere);
        }
        #endregion

    }
}