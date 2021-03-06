using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using DTcms.Common;
using DTcms.Model;
namespace DTcms.BLL{
	 	//StoreOutGoodsWithVehicles
		public partial class StoreOutGoodsWithVehicles
	{
   		     
		private readonly DTcms.DAL.StoreOutGoodsWithVehicles dal=new DTcms.DAL.StoreOutGoodsWithVehicles();
		public StoreOutGoodsWithVehicles()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int StoreOutGoodsStoreOutOrderId,int StoreOutGoodsId,int StoreOutGoodsVehicleId)
		{
			return dal.Exists(StoreOutGoodsStoreOutOrderId,StoreOutGoodsId,StoreOutGoodsVehicleId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(DTcms.Model.StoreOutGoodsWithVehicles model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DTcms.Model.StoreOutGoodsWithVehicles model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int StoreOutGoodsStoreOutOrderId,int StoreOutGoodsId,int StoreOutGoodsVehicleId)
		{
			
			return dal.Delete(StoreOutGoodsStoreOutOrderId,StoreOutGoodsId,StoreOutGoodsVehicleId);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DTcms.Model.StoreOutGoodsWithVehicles GetModel(int StoreOutGoodsStoreOutOrderId,int StoreOutGoodsId,int StoreOutGoodsVehicleId)
		{
			
			return dal.GetModel(StoreOutGoodsStoreOutOrderId,StoreOutGoodsId,StoreOutGoodsVehicleId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public DTcms.Model.StoreOutGoodsWithVehicles GetModelByCache(int StoreOutGoodsStoreOutOrderId,int StoreOutGoodsId,int StoreOutGoodsVehicleId)
        //{
			
        //    string CacheKey = "StoreOutGoodsWithVehiclesModel-" + StoreOutGoodsStoreOutOrderId+StoreOutGoodsId+StoreOutGoodsVehicleId;
        //    object objModel = DTcms.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(StoreOutGoodsStoreOutOrderId,StoreOutGoodsId,StoreOutGoodsVehicleId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = DTcms.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                DTcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (DTcms.Model.StoreOutGoodsWithVehicles)objModel;
        //}

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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DTcms.Model.StoreOutGoodsWithVehicles> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DTcms.Model.StoreOutGoodsWithVehicles> DataTableToList(DataTable dt)
		{
			List<DTcms.Model.StoreOutGoodsWithVehicles> modelList = new List<DTcms.Model.StoreOutGoodsWithVehicles>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DTcms.Model.StoreOutGoodsWithVehicles model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new DTcms.Model.StoreOutGoodsWithVehicles();					
													if(dt.Rows[n]["StoreOutGoodsStoreOutOrderId"].ToString()!="")
				{
					model.StoreOutGoodsStoreOutOrderId=int.Parse(dt.Rows[n]["StoreOutGoodsStoreOutOrderId"].ToString());
				}
																																if(dt.Rows[n]["StoreOutGoodsId"].ToString()!="")
				{
					model.StoreOutGoodsId=int.Parse(dt.Rows[n]["StoreOutGoodsId"].ToString());
				}
																																if(dt.Rows[n]["StoreOutGoodsVehicleId"].ToString()!="")
				{
					model.StoreOutGoodsVehicleId=int.Parse(dt.Rows[n]["StoreOutGoodsVehicleId"].ToString());
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
   
	}
}