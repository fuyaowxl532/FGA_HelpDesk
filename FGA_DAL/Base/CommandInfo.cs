using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA_DAL.Base
{
    public enum EffentNextType
    {
        /// <summary>
        /// ¶ÔÆäËûÓï¾äÎÞÈÎºÎÓ°Ïì 
        /// </summary>
        None,
        /// <summary>
        /// µ±Ç°Óï¾ä±ØÐëÎª"select count(1) from .."¸ñÊ½£¬Èç¹û´æÔÚÔò¼ÌÐøÖ´ÐÐ£¬²»´æÔÚ»Ø¹öÊÂÎñ
        /// </summary>
        WhenHaveContine,
        /// <summary>
        /// µ±Ç°Óï¾ä±ØÐëÎª"select count(1) from .."¸ñÊ½£¬Èç¹û²»´æÔÚÔò¼ÌÐøÖ´ÐÐ£¬´æÔÚ»Ø¹öÊÂÎñ
        /// </summary>
        WhenNoHaveContine,
        /// <summary>
        /// µ±Ç°Óï¾äÓ°Ïìµ½µÄÐÐÊý±ØÐë´óÓÚ0£¬·ñÔò»Ø¹öÊÂÎñ
        /// </summary>
        ExcuteEffectRows,
        /// <summary>
        /// Òý·¢ÊÂ¼þ-µ±Ç°Óï¾ä±ØÐëÎª"select count(1) from .."¸ñÊ½£¬Èç¹û²»´æÔÚÔò¼ÌÐøÖ´ÐÐ£¬´æÔÚ»Ø¹öÊÂÎñ
        /// </summary>
        SolicitationEvent
    }
    public class CommandInfo
    {
        public object ShareObject = null;
        public object OriginalData = null;
        event EventHandler _solicitationEvent;
        public event EventHandler SolicitationEvent
        {
            add
            {
                _solicitationEvent += value;
            }
            remove
            {
                _solicitationEvent -= value;
            }
        }
        public void OnSolicitationEvent()
        {
            if (_solicitationEvent != null)
            {
                _solicitationEvent(this, new EventArgs());
            }
        }
        public string CommandText;
        public System.Data.Common.DbParameter[] Parameters;
        public EffentNextType EffentNextType = EffentNextType.None;
        public CommandInfo()
        {

        }
        public CommandInfo(string sqlText, SqlParameter[] para)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
        }
        public CommandInfo(string sqlText, SqlParameter[] para, EffentNextType type)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
            this.EffentNextType = type;
        }
    }
}
