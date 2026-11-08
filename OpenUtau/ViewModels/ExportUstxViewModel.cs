using System;
using System.Collections.Generic;
using System.Linq;
using OpenUtau.Core;
using OpenUtau.Core.Editing;
using OpenUtau.Core.Ustx;
using ReactiveUI.SourceGenerators;

namespace OpenUtau.App.ViewModels {
    public partial class ExportUstxViewModel : ViewModelBase {
        private readonly UProject project;
        public readonly BatchEditProjectViewModel BatchEditProjectViewModel;

        [Reactive] public partial bool DoResetAllExpressions { get; set; }
        [Reactive] public partial bool DoResetPitchBends { get; set; }
        [Reactive] public partial bool DoResetAliases { get; set; }
        [Reactive] public partial bool DoResetVibratos { get; set; }

        public ExportUstxViewModel() {
            this.project = new UProject();
            BatchEditProjectViewModel = new BatchEditProjectViewModel(project);
        }

        public ExportUstxViewModel(UProject project) {
            this.project = project;
            BatchEditProjectViewModel = new BatchEditProjectViewModel(project);
        }
    }
}
