using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcyStorageClient.ViewModels
{
    public interface IChromeViewModel : IViewModel
    {
        IMainViewModel Main { get; }
    }
}
