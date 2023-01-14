
using System.Collections.Generic;
using _0_BaseRules.Application;
using Music.Domin.MusicStyleAgg;

namespace MusicManagement.Application.Contract.MusicStyle
{
    public interface IMusicStyleApplication
    {
        ResultOperation Create(CreateMusicStyle entity);

        ResultOperation Edit(EditMusicStyle entity);

        ResultOperation IsDeleted(long id);
        ResultOperation IsRestore(long id);
        EditMusicStyle GetById(long id);

        List<MusicStyleViewModel> Search(MusicStyleSearchModel searchModel);
    }
}
