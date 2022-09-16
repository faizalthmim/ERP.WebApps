using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Core.ViewModel
{
    public class JsonResultModel
    {

        public bool isSucceed
        {
            get;
            set;
        }

        public string message
        {
            get;
            set;
        }

        public JsonResultModel()
        {
            this.isSucceed = false;
            this.message = "";
        }

        public void ApproveSucceed()
        {
            this.isSucceed = true;
            this.message = "Approve Succeed";
        }

        public void InsertSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been created";
        }

        public void UpdateSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been updated";
        }

        public void DeleteSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been deleted";
        }
        public void DataIsExist(string id)
        {
            this.isSucceed = false;
            this.message = id + " already exist";
        }

        public void SubmitSucceed()
        {
            this.isSucceed = true;
            this.message = "Data has been submitted";
        }

        public void ProcessSucceed(string message)
        {
            this.isSucceed = true;
            this.message = "Data has been processed";
        }

        public void ProcessFailed(string message)
        {
            this.isSucceed = false;
            this.message = "Data has been failed to process";
        }
        public void ParentRule()
        {
            this.isSucceed = false;
            this.message = "this parent is descent from the same parent, Please try again using another parent ";
        }

        public void SetValues(bool isSuccess, string message)
        {
            this.isSucceed = isSuccess;
            this.message = message;
        }
    }
}
