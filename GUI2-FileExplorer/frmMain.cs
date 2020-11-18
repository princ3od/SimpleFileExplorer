using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI2_FileExplorer
{
    public partial class frmMain : Form
    {
        string selectedPath;
        bool isListviewMore = false;
        List<string> cutPaths = new List<string>();
        List<string> cutItems = new List<string>();
        List<string> copyPaths = new List<string>();
        List<string> copyItems = new List<string>();
        public frmMain()
        {
            InitializeComponent();
            toolStrDetails.Image = imageList1.Images["checked.png"];
            detailsToolStripMenuItem.Image = imageList1.Images["checked.png"];
            InitTreeView();
            splitContainer1.FixedPanel = FixedPanel.Panel1;
        }
        void InitTreeView()
        {
            treeviewMain.ImageList = imageList1;
            TreeNode root = new TreeNode("Computer");
            root.ImageKey = "computer.png";
            treeviewMain.Nodes.Add(root);
            foreach (var disk in DriveInfo.GetDrives())
            {
                root.Nodes.Add(disk.Name, disk.Name, "hard-disk.png", "hard-disk.png");
            }
            treeviewMain.DoubleClick += TreeviewMain_Click;
            listviewMain.DoubleClick += ListviewMain_DoubleClick;
            root.Expand();
        }

        private void ListviewMain_DoubleClick(object sender, EventArgs e)
        {
            if (selectedPath.Substring(selectedPath.Length - 1, 1) == ":")
                selectedPath += Path.DirectorySeparatorChar;
            string path = Path.Combine(selectedPath, listviewMain.SelectedItems[0].SubItems[0].Text);
            TreeNode[] treeNodes = treeviewMain.Nodes.Find(listviewMain.SelectedItems[0].SubItems[0].Text, true);
            FileAttributes selectedItem = File.GetAttributes(path);
            if (selectedItem.HasFlag(FileAttributes.Directory))
            {
                isListviewMore = true;
                selectedPath = path;
                ShowMoreListView(path);
                if (treeNodes.Length > 0)
                    foreach (TreeNode treeNode in treeNodes)
                    {
                        string nodePath = treeNode.FullPath.Replace("Computer\\", "");
                        if (nodePath.Replace(@"\\", @"\") == selectedPath)
                        {
                            treeviewMain.SelectedNode = treeNode;
                            treeviewMain.Focus();
                        }
                    }
            }
            else
            {
                FileOperationHelper.OpenFile(path);
            }
            txtAdresss.Text = selectedPath;
        }

        private void TreeviewMain_Click(object sender, EventArgs e)
        {
            isListviewMore = false;
            if (treeviewMain.SelectedNode != null && treeviewMain.SelectedNode != treeviewMain.Nodes[0])
            {
                if (ExpandTree(treeviewMain.SelectedNode))
                    ExpandListView(treeviewMain.SelectedNode);
            }
        }

        bool ExpandTree(TreeNode _selectedNode)
        {
            string path = _selectedNode.FullPath.Replace("Computer\\", "").Replace(@"\\", @"\");
            selectedPath = path;

            _selectedNode.Nodes.Clear();
            try
            {
                DirectoryInfo selectedDir = new DirectoryInfo(path);
                foreach (var directory in selectedDir.GetDirectories())
                {
                    if (directory.Attributes != FileAttributes.System)
                        _selectedNode.Nodes.Add(directory.Name, directory.Name, "folder.png", "folder.png");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }
            _selectedNode.Expand();
            txtAdresss.Text = selectedPath;
            return true;
        }
        bool ShowMoreListView(string _path)
        {
            listviewMain.Items.Clear();
            string path = _path;
            try
            {
                DirectoryInfo selectedDir = new DirectoryInfo(path);
                foreach (DirectoryInfo directory in selectedDir.GetDirectories())
                {
                    if (directory.Attributes != FileAttributes.System)
                        listviewMain.Items.Add(new ListViewItem(new string[]
                        {
                            directory.Name,
                            "Folder",
                            "",
                            directory.CreationTime.ToLongTimeString(),
                            directory.LastWriteTime.ToLongTimeString()
                        }, 1));
                }
                foreach (FileInfo file in selectedDir.GetFiles())
                {
                    if (!listviewMain.SmallImageList.Images.Keys.Contains(file.Extension))
                    {
                        listviewMain.SmallImageList.Images.Add(file.Extension, Icon.ExtractAssociatedIcon(file.FullName));
                        listviewMain.LargeImageList.Images.Add(file.Extension, Icon.ExtractAssociatedIcon(file.FullName));
                    }
                    if (file.Attributes != FileAttributes.System)
                        listviewMain.Items.Add(new ListViewItem(new string[]
                        {
                            file.Name,
                            file.Extension,
                            file.Length.ToString(),
                            file.CreationTime.ToLongTimeString(),
                            file.LastWriteTime.ToLongTimeString()
                        }, file.Extension));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }
            txtAdresss.Text = selectedPath;
            if (listviewMain.Items.Count == 0)
                lbEmpty.Show();
            else
                lbEmpty.Hide();
            return true;
        }
        bool ExpandListView(TreeNode _selectedNode)
        {
            listviewMain.Items.Clear();
            string path = _selectedNode.FullPath.Replace("Computer\\", "").Replace(@"\\", @"\");
            try
            {
                DirectoryInfo selectedDir = new DirectoryInfo(path);
                foreach (DirectoryInfo directory in selectedDir.GetDirectories())
                {
                    if (directory.Attributes != FileAttributes.System)
                        listviewMain.Items.Add(new ListViewItem(new string[]
                        {
                            directory.Name,
                            "Folder",
                            "",
                            directory.CreationTime.ToLongTimeString(),
                            directory.LastWriteTime.ToLongTimeString()
                        }, 1));
                }
                foreach (FileInfo file in selectedDir.GetFiles())
                {
                    if (!listviewMain.SmallImageList.Images.Keys.Contains(file.Extension))
                    {
                        listviewMain.SmallImageList.Images.Add(file.Extension, Icon.ExtractAssociatedIcon(file.FullName));
                        listviewMain.LargeImageList.Images.Add(file.Extension, Icon.ExtractAssociatedIcon(file.FullName));
                    }
                    if (file.Attributes != FileAttributes.System)
                        listviewMain.Items.Add(new ListViewItem(new string[]
                        {
                            file.Name,
                            file.Extension,
                            file.Length.ToString(),
                            file.CreationTime.ToLongTimeString(),
                            file.LastWriteTime.ToLongTimeString()
                        }, file.Extension));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }
            _selectedNode.Expand();
            txtAdresss.Text = selectedPath;
            if (listviewMain.Items.Count == 0)
                lbEmpty.Show();
            else
                lbEmpty.Hide();
            return true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeviewMain.SelectedNode == null && treeviewMain.SelectedNode == treeviewMain.Nodes[0])
                return;
            string path = treeviewMain.SelectedNode.FullPath.Replace("Computer\\", "");
            if (MessageBox.Show("Chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (listviewMain.Focused)
            {
                foreach (ListViewItem item in listviewMain.SelectedItems)
                {
                    string corePath = Path.Combine(selectedPath, item.SubItems[0].Text);
                    FileAttributes fileAttributes = File.GetAttributes(corePath);
                    if (fileAttributes.HasFlag(FileAttributes.Directory))
                    {
                        try
                        {
                            Directory.Delete(corePath);
                            if (!isListviewMore)
                            {
                                treeviewMain.Nodes.Remove(treeviewMain.SelectedNode.Parent.Nodes.Find(item.SubItems[0].Text, true)[0]);
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message == "The directory is not empty.\r\n")
                            {
                                DialogResult dialog = MessageBox.Show("Folder có dữ liệu, chắc chắn xóa?", corePath, MessageBoxButtons.YesNo);
                                if (dialog == DialogResult.No)
                                    return;
                                Directory.Delete(corePath, true);
                                if (!isListviewMore)
                                {
                                    treeviewMain.Nodes.Remove(treeviewMain.SelectedNode.Parent.Nodes.Find(item.SubItems[0].Text, true)[0]);
                                }
                            }
                        }

                    }
                    else
                    {
                        File.Delete(corePath);
                    }
                    listviewMain.Items.Remove(item);
                }

            }
            else
            {
                try
                {
                    Directory.Delete(path);
                    ExpandListView(treeviewMain.SelectedNode.Parent);
                    treeviewMain.Nodes.Remove(treeviewMain.SelectedNode);

                }
                catch (Exception ex)
                {
                    if (ex.Message == "The directory is not empty.\r\n")
                    {
                        DialogResult dialog = MessageBox.Show("Folder có dữ liệu, chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.No)
                            return;
                        Directory.Delete(path, true);
                        ListViewItem[] items = listviewMain.Items.Find(treeviewMain.SelectedNode.Text, true);
                        foreach (ListViewItem item in items)
                        {
                            listviewMain.Items.Remove(item);
                        }
                        treeviewMain.Nodes.Remove(treeviewMain.SelectedNode);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tstripbtnDelete_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.PerformClick();
        }

        private void tstripbtnUp_Click(object sender, EventArgs e)
        {
            selectedPath = FileOperationHelper.UpFolder(selectedPath);
            txtAdresss.Text = selectedPath;
            ShowMoreListView(selectedPath);
        }

        private void tstripbtnRefresh_Click(object sender, EventArgs e)
        {
            ShowMoreListView(selectedPath);
        }
        private void ChooseViewsType(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem itemm in viewsToolStripMenuItem.DropDownItems)
            {
                if (itemm.Image != null)
                {
                    itemm.Image.Dispose();
                    itemm.Image = null;
                }
            }
            foreach (ToolStripMenuItem itemm in tstripbtnViews.DropDownItems)
            {
                if (itemm.Image != null)
                {
                    itemm.Image.Dispose();
                    itemm.Image = null;
                }
            }
            ToolStripMenuItem item = (sender as ToolStripMenuItem);
            switch (item.Name)
            {
                case "toolstrLargeIcon":
                case "largeIconToolStripMenuItem":
                    listviewMain.View = View.LargeIcon;
                    toolstrLargeIcon.Image = imageList1.Images["checked.png"];
                    largeIconToolStripMenuItem.Image = imageList1.Images["checked.png"];
                    break;
                case "toolstrSmallIcon":
                case "smallIconToolStripMenuItem":
                    listviewMain.View = View.SmallIcon;
                    toolstrSmallIcon.Image = imageList1.Images["checked.png"];
                    smallIconToolStripMenuItem.Image = imageList1.Images["checked.png"];
                    break;
                case "toolstrList":
                case "listsToolStripMenuItem":
                    listviewMain.View = View.List;
                    toolstrList.Image = imageList1.Images["checked.png"];
                    listsToolStripMenuItem.Image = imageList1.Images["checked.png"];
                    break;
                case "toolStrDetails":
                case "detailsToolStripMenuItem":
                    listviewMain.View = View.Details;
                    toolStrDetails.Image = imageList1.Images["checked.png"];
                    detailsToolStripMenuItem.Image = imageList1.Images["checked.png"];
                    break;
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listviewMain.SelectedItems.Count != 0)
            {
                listviewMain.Focus();
                listviewMain.SelectedItems[0].BeginEdit();
            }
            else
            {
                if (treeviewMain.SelectedNode == null)
                    return;
                treeviewMain.Focus();
                treeviewMain.SelectedNode.BeginEdit();
            }
        }

        private void listviewMain_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            string oldPath = Path.Combine(selectedPath, listviewMain.SelectedItems[0].SubItems[0].Text);
            string newPath = Path.Combine(selectedPath, e.Label);
            if (!FileOperationHelper.Rename(oldPath, newPath))
            {
                MessageBox.Show("Tên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
                return;
            }
            TreeNode[] treeNodes = treeviewMain.Nodes.Find(listviewMain.SelectedItems[0].SubItems[0].Text, true);
            if (treeNodes.Length > 0)
                foreach (TreeNode treeNode in treeNodes)
                {
                    string nodePath = treeNode.FullPath.Replace("Computer\\", "");
                    if (nodePath.Replace(@"\\", @"\") == oldPath)
                    {
                        treeNode.Text = e.Label;
                        break;
                    }
                }
        }

        private void treeviewMain_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            string oldPath = treeviewMain.SelectedNode.FullPath.Replace("Computer\\", "");
            string newPath = Path.Combine(FileOperationHelper.UpFolder(oldPath), e.Label);
            if (!FileOperationHelper.Rename(oldPath, newPath))
            {
                MessageBox.Show("Tên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
                return;
            }
            if (FileOperationHelper.UpFolder(oldPath).Replace(@"\\", @"\") == selectedPath)
                foreach (ListViewItem item in listviewMain.Items)
                {
                    if (item.SubItems[0].Text == treeviewMain.SelectedNode.Text)
                        item.SubItems[0].Text = e.Label;
                }
        }
        void ClearClipboard()
        {
            cutPaths.Clear();
            cutItems.Clear();
            copyItems.Clear();
            copyPaths.Clear();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeviewMain.SelectedNode == null && treeviewMain.SelectedNode == treeviewMain.Nodes[0] || string.IsNullOrEmpty(selectedPath))
                return;
            ClearClipboard();
            string path = treeviewMain.SelectedNode.FullPath.Replace("Computer\\", "");
            if (listviewMain.Focused)
            {
                foreach (ListViewItem item in listviewMain.SelectedItems)
                {
                    string corePath = Path.Combine(selectedPath, item.SubItems[0].Text);
                    cutPaths.Add(corePath);
                    cutItems.Add(item.SubItems[0].Text);
                    item.ForeColor = Color.Gray;
                    item.BackColor = Color.WhiteSmoke;
                }
            }
            else
            {
                treeviewMain.SelectedNode.ForeColor = Color.Gray;
                treeviewMain.SelectedNode.BackColor = Color.WhiteSmoke;
                cutPaths.Add(path);
                cutItems.Add(treeviewMain.SelectedNode.Text);
            }
        }

        private void tstripbtnCut_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeviewMain.SelectedNode == null && treeviewMain.SelectedNode == treeviewMain.Nodes[0] || string.IsNullOrEmpty(selectedPath))
                return;
            ClearClipboard();
            string path = treeviewMain.SelectedNode.FullPath.Replace("Computer\\", "");
            if (listviewMain.Focused)
            {
                foreach (ListViewItem item in listviewMain.SelectedItems)
                {
                    string corePath = Path.Combine(selectedPath, item.SubItems[0].Text);
                    copyPaths.Add(corePath);
                    copyItems.Add(item.SubItems[0].Text);
                }
            }
            else
            {
                copyPaths.Add(path);
                copyItems.Add(treeviewMain.SelectedNode.Text);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            string pastePath = selectedPath;
            if (treeviewMain.Focused && treeviewMain.SelectedNode != null)
                pastePath = treeviewMain.SelectedNode.FullPath.Replace("Computer\\", "");
            if (cutItems.Count > 0)
            {
                foreach (string item in cutItems)
                {
                    string newPath = Path.Combine(pastePath, item);
                    if (newPath == cutPaths[i])
                        continue;
                    if (selectedPath.Substring(selectedPath.Length - 1, 1) == ":")
                        selectedPath += Path.DirectorySeparatorChar;
                    FileAttributes fileAttributes = File.GetAttributes(cutPaths[i]);
                    if (!FileOperationHelper.Rename(cutPaths[i], newPath))
                        MessageBox.Show("Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (fileAttributes.HasFlag(FileAttributes.Directory))
                            treeviewMain.SelectedNode.Nodes.Add(item, item, "folder.png", "folder.png");
                        TreeNode[] treeNodes = treeviewMain.Nodes.Find(item, true);
                        if (treeNodes.Length > 0)
                            foreach (TreeNode treeNode in treeNodes)
                            {
                                string nodePath = treeNode.FullPath.Replace("Computer\\", "");
                                if (nodePath.Replace(@"\\", @"\") == cutPaths[i])
                                {
                                    treeviewMain.Nodes.Remove(treeNode);
                                }
                            }
                    }
                    i++;
                }
                ShowMoreListView(selectedPath);
                ExpandTree(treeviewMain.SelectedNode);
                ClearClipboard();
            }
            else if (copyItems.Count > 0)
            {
                foreach (string item in copyItems)
                {
                    string newPath = Path.Combine(pastePath, item);
                    if (newPath == copyPaths[i])
                        continue;
                    if (selectedPath.Substring(selectedPath.Length - 1, 1) == ":")
                        selectedPath += Path.DirectorySeparatorChar;
                    FileAttributes fileAttributes = File.GetAttributes(copyPaths[i]);
                    if (!FileOperationHelper.Copy(copyPaths[i], newPath))
                        MessageBox.Show("Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (fileAttributes.HasFlag(FileAttributes.Directory))
                            treeviewMain.SelectedNode.Nodes.Add(item, item, "folder.png", "folder.png");
                    }
                    i++;
                }
                ShowMoreListView(selectedPath);
            }

        }

        private void tstripbtnCopy_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void tstripbtnPaste_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }

        private void txtAdresss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    FileAttributes fileAttributes = File.GetAttributes(txtAdresss.Text);
                    if (fileAttributes.HasFlag(FileAttributes.Directory))
                        selectedPath = txtAdresss.Text;
                    else
                    {
                        FileOperationHelper.OpenFile(txtAdresss.Text);
                        selectedPath = FileOperationHelper.UpFolder(txtAdresss.Text);
                        txtAdresss.Text = selectedPath;
                    }
                    ShowMoreListView(selectedPath);

                }
                catch
                {
                    MessageBox.Show("Đường dẫn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Bài thực hành GUI 2 - môn Lập trình Trực Quan (IT008)\n" +
                "- GVHD: thầy Nguyễn Tấn Toàn \n" +
                "- Tác giả: Dương Bình Trọng - 19521056 - KTPM2019\n" +
                "- Khoa Công nghệ Phần mềm - trường Đại học Công nghệ Thông tin - ĐHQG-TPHCM."
                , "About"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
    }
}
