using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertData
{
    public class MethodInsertController
    {
        #region Instances
        MethodInsertData InsertData = new MethodInsertData();

        #endregion

        #region Methods
        public void DataInsert(int id, List<InfoDataModel> vListData)
        {
            InsertData.InsertData(id, vListData);
        } 

        #endregion
    }
}