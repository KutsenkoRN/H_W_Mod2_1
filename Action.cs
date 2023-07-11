using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_2_1
{

    internal class Actions
    {
        private readonly Logger logger;

        public Actions()
        {
            logger = Logger.Instance;
        }

        public Result GetStart()
        {
            {
                logger.Log(LogType.Info, $"Start method: {nameof(GetStart)}");
                return new Result { Status = true };
            }
        }

        public Result GetSkipLogic()
        {
            logger.Log(LogType.Warning, $"Skipped logic in method: {nameof(GetSkipLogic)}");
            return new Result { Status = true };
        }

        public Result BreakLogic()
        {
            Result result = new Result { Status = false, ErrorMessage = "I broke a logic" };
            logger.Log(LogType.Error, $"Action failed by a reason: {result.ErrorMessage}");
            return result;
        }
    }
}
