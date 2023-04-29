// Copyright (c) 2023 Onkgopotse Lenake. Web: https://www.onkgopotselenake.me/.
// Licensed under the MIT license. See LICENSE file for license information.

using OFLenake.Core.Common;

namespace OFLenake.Core.Entities
{
    public class TodoList : AuditableEntity
    {
        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Colour { get; set; }

        public IList<TodoItem>? Items { get; set; }
    }
}
