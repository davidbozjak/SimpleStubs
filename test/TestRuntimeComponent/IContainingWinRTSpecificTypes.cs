using Windows.Foundation;

namespace TestRuntimeComponent
{
    public interface IContainingWinRTSpecificTypes
    {
        IAsyncAction GetAsyncAction();

        IAsyncOperation<bool> GetAsyncOperation();
    }
}
