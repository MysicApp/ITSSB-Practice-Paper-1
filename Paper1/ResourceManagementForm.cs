using System.Data;
using Paper1.Db;

namespace Paper1
{
    public partial class ResourceManagementForm : Form
    {
        readonly Backable Backable;

        public ResourceManagementForm(Form previous_form)
        {
            InitializeComponent();
            Backable = new Backable(this, previous_form);
        }

        private void ResourceManagementForm_Load(object sender, EventArgs e)
        {
            using (var context = new Session1Context())
            {
                var resourceTypes = from rt in context.ResourceTypes select rt.ResTypeName;
                var resourceTypesList = resourceTypes.ToList();
                resourceTypesList.Insert(0, "");
                ComboType.DataSource = resourceTypesList;

                var skills = from s in context.Skills select s.SkillName;
                var skillsList = skills.ToList();
                skillsList.Insert(0, "");
                ComboSkill.DataSource = skillsList;
            }
            dataGridView1.DataSource = GetResources();
        }

        private static List<object> GetResources(string typeFilter = "", string skillFilter = "")
        {
            // Fuck you null
            typeFilter ??= "";
            skillFilter ??= "";

            using var context = new Session1Context();
            return context.ResourceAllocations
            // Join resource names
            .Join(context.Resources,
            ra => ra.ResIdFk,
            r => r.ResId,
            (ra, r) => new
            {
                r.ResId,
                Name = r.ResName,
                AvaliableQuantity = r.RemainingQuantity < 0 ? "Error" :
                                     r.RemainingQuantity == 0 ? "Not available" :
                                     r.RemainingQuantity <= 5 ? "Low Stock" :
                                     "Sufficient",
                SKillIdFK = ra.SkillIdFk,
                ResTypeIdFK = r.ResTypeIdFk,
            })
            // Join resource type names
            .Join(context.ResourceTypes,
            ra => ra.ResTypeIdFK,
            rt => rt.ResTypeId,
            (ra, rt) => new
            {
                ra.ResId,
                ra.Name,
                Type = rt.ResTypeName,
                ra.AvaliableQuantity,
                ra.SKillIdFK,
            })
            // Join skill names
            .Join(context.Skills,
            ra => ra.SKillIdFK,
            s => s.SkillId,
            (ra, s) => new
            {
                ra.ResId,
                ra.Name,
                ra.Type,
                s.SkillName,
                ra.AvaliableQuantity
            })
            // Group allocations by resource
            .GroupBy(ra => ra.ResId)
            // Filter by type
            .Where(g => g.Select(ra => ra.Type).First() == typeFilter || typeFilter == "")
            // Filter by skill
            .Where(g => g.Select(ra => ra.SkillName).Contains(skillFilter) || skillFilter == "")
            // Select columns
            .Select(g => (object)new
            {
                Name = g.Select(ra => ra.Name).First(),
                Type = g.Select(ra => ra.Type).First(),
                NoOfSkills = g.Count(),
                AllocatedSkills = string.Join(", ", g.Select(ra => ra.SkillName)),
                AvaliableQuantity = g.Select(ra => ra.AvaliableQuantity),
            })
            .ToList();
        }

        private void BtnBack_Click(object sender, EventArgs e) => Backable.BackToParent();

        private void ComboType_SelectedValueChanged(object sender, EventArgs e) => UpdateResourcesTable();

        private void ComboSkill_SelectedValueChanged(object sender, EventArgs e) => UpdateResourcesTable();

        private void UpdateResourcesTable()
        {
            var resourceAllocation = GetResources((string)ComboType.SelectedValue,
                (string)ComboSkill.SelectedValue);
            dataGridView1.DataSource = resourceAllocation;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
