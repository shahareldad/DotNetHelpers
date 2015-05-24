using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace WPF_MVVM
{
    public class PropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(Expression<Func<object>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression != null)
                OnPropertyChanged(memberExpression.Member.Name);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
