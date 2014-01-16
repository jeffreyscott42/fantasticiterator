using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasure.Core
{
    public class DivisorRequest
    {

        #region Constructors

        public DivisorRequest(int value, string message)
        {

            // make sure data is valid 
            List<string> errors = this.ValidateEntries(value, message);

            // if so, then save to object properties, else throw exception
            if( errors.Count == 0 )
            {
                this.Value = value;
                this.Message = message;
            }
            else
            {
                throw new InvalidDataException(BuildFullException(errors));
            }

        }

        #endregion

        #region Properties
        private int _requestValue = 0;
        public int Value
        {
            get { return _requestValue; }
            set { _requestValue = value; }
        }

        private string _requestMessage = "";
        public string Message
        {
            get { return _requestMessage; }
            set { _requestMessage = value; }
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Validate user-provided values
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <returns>Collection of errors found</returns>
        private List<string> ValidateEntries(int value, string message)
        {
            //bool isValid = true;
            List<String> errors = new List<String>();

            if (message.Length == 0)
            {
                //isValid = false;
                errors.Add("Error: Message is a required field, but was empty.");
            }

            if (value <= 0)
            {
                //isValid = false;
                errors.Add("Divisor must be positve, and greater than 0");
            }

            return errors;
        }

        /// <summary>
        /// Build a single error message from multiple errors 
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        private string BuildFullException(List<string> errors)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Error(s) occurred while building this object: ");
            foreach (string error in errors )
            {
                sb.Append(error);
            }
            return sb.ToString();
        }

        #endregion

    }
}
