using System.Collections.Generic;

public interface ISong
{
    List<Notes> getLeftHand();
    List<Notes> getRightHand();
    string SongName { get; }
}
