using UsingTag;
using System;
using Glove;

csharp.onGetCode.first("using") :: getUsingTag(
  {
    foreach(var prf in getUsingTag())
    {
      if (!prf is System.EnabledPreferenceID) return;
      else
      {
        foreach(var tag in getUsingTag())
        {
          Glove.createObject(all{toForce} = tag{setForce});
        }
      }
    }
  }
)
