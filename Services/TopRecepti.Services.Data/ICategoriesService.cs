﻿namespace TopRecepti.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKetValuePairs();
    }
}
