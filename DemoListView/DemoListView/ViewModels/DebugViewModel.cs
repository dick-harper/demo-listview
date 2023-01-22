using System;
using DemoListView.Models;
using Xamarin.CommunityToolkit.ObjectModel;

namespace DemoListView.ViewModels
{
    public class DebugViewModel : ObservableObject
    {
        private ObservableRangeCollection<DebugInfo> _debugInfos;
        private DebugInfo _selectedDebugInfo;

        public DebugViewModel()
        {
            _debugInfos = GetData();
        }

        public ObservableRangeCollection<DebugInfo> DebugInfos
        {
            get => _debugInfos;

            set => SetProperty(ref _debugInfos, value);
        }

        private ObservableRangeCollection<DebugInfo> GetData()
        {
            return new ObservableRangeCollection<DebugInfo>
            {
                new DebugInfo
                {
                    CustomerName = "Test Customer 1",
                    DeviceId="dZxuu14",
                    AccessCode="A23780",
                    RawRssi = -68,
                    CorrectedRssi = -72
                },
                new DebugInfo
                {
                    CustomerName = "Test Customer 2",
                    DeviceId="m14KK23",
                    AccessCode="A43788",
                    RawRssi = -65,
                    CorrectedRssi = -74
                },
                new DebugInfo
                {
                    CustomerName = "Test Customer 3",
                    DeviceId="L23sb7",
                    AccessCode="A60126",
                    RawRssi = -45,
                    CorrectedRssi = -45
                },
                new DebugInfo
                {
                    CustomerName = "Test Customer 4",
                    DeviceId="k12zc2",
                    AccessCode="A51926",
                    RawRssi = 0,
                    CorrectedRssi = 0
                },
                new DebugInfo
                {
                    CustomerName = "Test Customer 5",
                    DeviceId="t14zzW",
                    AccessCode="A71206",
                    RawRssi = -32,
                    CorrectedRssi = -47
                }
            };
        }
    }
}

