namespace DesignPatterns.Behavioral.Specification
{
    using DesignPatterns.Behavioral.Specification.Core.Implementation;
    using System;
    using System.Linq.Expressions;

    public class MarkStudentSpecification : SpecificationComposite<Student>
    {
        private readonly Student _student;

        public MarkStudentSpecification(Student student)
        {
            this._student = student;
        }

        public override Expression<Func<Student, bool>> ToExpression()
        {
            return student => this._student.Name.Contains("Mark", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
