namespace DesignPatterns.Behavioral.Tests
{
    using System.Collections;
    using System.Collections.Generic;

    public abstract class TheoryData : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>();

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        protected void AddRow(params object[] values)
        {
            data.Add(values);
        }
    }

    public class TheoryDataInput<TExpected, TParameter> : TheoryData
    {
        public void Add(TExpected expected, TParameter parameter)
        {
            base.AddRow(expected, parameter);
        }
    }
}
