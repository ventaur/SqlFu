﻿using System.Collections.Generic;
using SqlFu;
using SqlFu.DDL.Internals;
using Xunit;
using System;
using System.Diagnostics;

namespace Tests
{
    public class Generic
    {
        private Stopwatch _t = new Stopwatch();

        public Generic()
        {

        }

       // [Fact]
        public void stored()
        {
            var st = Setup.GetDb().ExecuteStoredProcedure("bla",new{Param1="bla",_Param2=0});
            Assert.Equal(1,st.ReturnValue);
            Assert.Equal(34,st.OutputValues["Param2"]);
        }

        public enum TT:long
        {
            None=0
        }

        [Fact]
        public void FactMethodName()
        {
            dynamic d = new SqlFuDynamic(new KeyValuePair<string, object>[0]);
            Assert.Throws<InvalidOperationException>(() => { d.La = "23"; });

        }


        private void Write(string format, params object[] param)
        {
            Console.WriteLine(format, param);
        }
    }
}