using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public static class Extensions
    {

        public static bool SetValue<T>(this PropertyChangedBase viewModel, ref T field, T newValue, [CallerMemberName] string propertyName=null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }

            field = newValue;
            viewModel.NotifyOfPropertyChange(propertyName);
            return true;
        }

        public static bool SetValue<T>(this PropertyChangedBase viewModel, ref T field, T newValue, Expression<Func<T>> propertyExpression)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }
            field = newValue;
            viewModel.NotifyOfPropertyChange(propertyExpression);
            return true;
        }

        
    }
}
