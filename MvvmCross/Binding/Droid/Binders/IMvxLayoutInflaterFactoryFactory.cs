// IMvxLayoutInflaterFactoryFactory.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.Binding.Droid.Binders
{
    public interface IMvxLayoutInflaterFactoryFactory
    {
        IMvxLayoutInflaterFactory Create(object source);
    }
}