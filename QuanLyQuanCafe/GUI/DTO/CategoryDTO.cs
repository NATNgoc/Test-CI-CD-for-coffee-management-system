using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [ExcludeFromCodeCoverage]
    // Stryker disable all

    public class CategoryDTO
    {
        private int id;
        private string name;

        public string Name { get { return name; } set {  name = value; } }
        public int Id { get { return id; } set { id = value; } }

        public CategoryDTO(int id,string name) { 
        this.id = id;
        this.name = name;
        
        
        }
        public CategoryDTO() { }

    }
}
