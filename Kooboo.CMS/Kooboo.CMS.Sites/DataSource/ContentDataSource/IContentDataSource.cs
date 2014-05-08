﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.CMS.Content.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kooboo.CMS.Sites.DataSource.ContentDataSource
{
    public interface IContentDataSource : IDataSource
    {
        string FolderName { get; set; }

        Schema GetSchema(Repository repository);

        bool IsValid(Repository repository);

        bool? EnablePaging { get; set; }
    }
}
