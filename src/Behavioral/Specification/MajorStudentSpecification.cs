namespace DesignPatterns.Behavioral.Specification
{
    using DesignPatterns.Behavioral.Specification.Core.Implementation;
    using System;
    using System.Linq.Expressions;

    public class MajorStudentSpecification : SpecificationComposite<Student>
    {
        private readonly Student _student;

        public MajorStudentSpecification(Student student)
        {
            this._student = student;
        }

        public override Expression<Func<Student, bool>> ToExpression()
        {
            return student => this._student.BirthDate <= DateTime.Now.AddYears(-18);
        }
    }
}
