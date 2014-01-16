using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasure.Core
{
    /// <summary>
    /// Our fantastic product, the FantasticIterator class
    /// </summary>
    public class FantasicIterator
    {
        #region Private Variables
        List<DivisorRequest> _requests = new List<DivisorRequest>();
        #endregion

        #region Constructors
        public FantasicIterator()
        {

        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Consumer will provide (a) number to check for and (b) word to replace it with
        /// </summary>
        /// <param name="request">Populated request object</param>
        public void AddRequest(DivisorRequest request)
        {
            _requests.Add(request);
        }


        public string IterateRange(int startValue, int endValue)
        {

            StringBuilder sbResult = new StringBuilder();

            for (int i = startValue; i <= endValue; i++)
            {

                StringBuilder sb = new StringBuilder();

                if (i % 3 == 0)
                {
                    sb.Append("Fizz");
                }

                if (i % 5 == 0)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(",");
                    }
                    sb.Append("Buzz");
                }

                if (sb.Length == 0)
                {
                    sb.Append(i.ToString());

                }

                sbResult.Append(sb.ToString());


            }
            return sbResult.ToString();
        }


        /// <summary>
        /// Method that performs that iterates through the numbers, performing the user-defined checks
        /// </summary>
        /// <param name="startValue">start value of the range</param>
        /// <param name="endValue">ending value of the range</param>
        /// <returns>Results of the Iteration with matches replaced with words</returns>
        public string Iterate(int startValue, int endValue)
        {
            // data validatiomn
            if( endValue <= startValue)
            {
                throw new InvalidDataException("startValue must be less than the endValue");
            }
            
            StringBuilder sbResult = new StringBuilder();

            for (int i = startValue; i <= endValue; i++)
            {

                StringBuilder sb = new StringBuilder();

                foreach (DivisorRequest request in _requests)
                {
                    // perform user-defined check
                    if (i % request.Value == 0)
                    {
                        // if not 1st message retured then make comma delimited
                        if (sb.Length > 0)
                        {
                            sb.Append(",");
                        }

                        // if a match, write user-defined message
                        sb.Append(request.Message);
                    }

                }

                // if nothing found, then display number itself
                if (sb.Length == 0)
                {
                    sb.Append(i.ToString());
                }

                // write full result for this number
                sbResult.AppendLine(sb.ToString());

            }

            return sbResult.ToString();
            sbResult.Clear();

        }
        #endregion
    } 

} 