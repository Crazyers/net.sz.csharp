using Net.Sz.Framework.Netty.Http;
using System;

/**
 * 
 * @author ʧ�����Ա
 * @Blog http://www.cnblogs.com/ty408/
 * @mail 492794628@qq.com
 * @phone 13882122019
 * 
 */

namespace Net.Sz.Framework.Netty.Http
{

    /// <summary>
    /// http��������
    /// <para>@author ʧ�����Ա</para>
    /// <para>@Blog http://www.cnblogs.com/ty408/</para>
    /// <para>@mail 492794628@qq.com</para>
    /// <para>@phone 13882122019</para>
    /// </summary>
    public class ActionHttpHandler : IHttpHandler
    {

        private Action<HttpSession> ARun;

        public ActionHttpHandler(Action<HttpSession> run)
        {
            this.ARun = run;
        }

        /// <summary>
        /// ���������
        /// </summary>
        /// <param name="session">���Ӷ���</param>
        public void Run(HttpSession session)
        {
            this.ARun(session);
        }

    }
}