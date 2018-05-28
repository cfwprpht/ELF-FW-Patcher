using SwissKnife;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ELF_FW_Patcher {
    public partial class ElfFwPatcher : Form {
        /// <summary>
        /// An array to store the selcted file(s).
        /// </summary>
        private string[] files;

        private string[] sdk_versions = { "03508031", "04508111", };

        /// <summary>
        /// Instance Initializer.
        /// </summary>
        public ElfFwPatcher() { InitializeComponent(); }

        /// <summary>
        /// Check if ELFs of the base are Decrypted.
        /// </summary>
        /// <param name="path">Path to the template folder.</param>
        private bool IsElfDecrypted(string file) {
            byte[] magic = new byte[4] { 0x7F, 0x45, 0x4C, 0x46, };

            using (BinaryReader binReader = new BinaryReader(new FileStream(file, FileMode.Open, FileAccess.Read))) {
                byte[] fmagic = new byte[4];
                binReader.Read(fmagic, 0, 4);
                if (!magic.Contains(fmagic)) return false;
                binReader.Close();
            }
            return true;
        }

        /// <summary>
        /// On Load of Form do.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The Evnet Arguments.</param>
        private void ElfFwPatcher_Load(object sender, EventArgs e) {
            status.Text = "Welcome !";
            comboLookup.Items.AddRange(sdk_versions);
            comboPatch.Items.AddRange(sdk_versions);
        }

        /// <summary>
        /// On Button Select Click do.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The Evnet Arguments.</param>
        private void ButtonSelect_Click(object sender, EventArgs e) {
            if (radioFile.Checked) {
                if (selectFile.ShowDialog() == DialogResult.OK) {
                    if (selectFile.FileNames.Length > 0) {
                        files = new string[selectFile.FileNames.Length];
                        files = selectFile.FileNames;
                    } else if (selectFile.FileName != string.Empty) {
                        files = new string[1];
                        files[0] = selectFile.FileName;
                    } else { MessageBox.Show("No File(s) choosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    textBoxInput.Text = files[0];
                }
            } else {
                if (selectFolder.ShowDialog() == DialogResult.OK) {
                    textBoxInput.Text = selectFolder.SelectedPath;
                    string[] elfFiles = Directory.GetFiles(selectFolder.SelectedPath, "*.elf");
                    if (elfFiles.Length > 0) {
                        files = new string[elfFiles.Length];
                        files = elfFiles;
                    } else MessageBox.Show("No ELF(s) found within this folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Magic Mike Routine.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The Evnet Arguments.</param>
        private void ButtonPatch_Click(object sender, EventArgs e) {
            Application.DoEvents();
            if (comboLookup.SelectedIndex >= 0) {
                if (comboPatch.SelectedIndex >= 0) {
                    string lookup = comboLookup.Items[comboLookup.SelectedIndex].ToString();
                    string patch = comboPatch.Items[comboPatch.SelectedIndex].ToString();
                    if (lookup.Length == 8) {
                        if (patch.Length == 8) {
                            if (lookup.IsHex()) {
                                if (patch.IsHex()) {
                                    if (files.Length > 0) {
                                        int patched = 0;
                                        try {
                                            status.Text = "Working...";
                                            progressBar.Maximum = files.Length;
                                            progressBar.Step = 1;
                                            long offset = 0;
                                            byte[] toLookup = new byte[4];
                                            byte[] toPatch = new byte[4];
                                            byte[] check = new byte[4];
                                            toLookup = lookup.EndianSwapp().HexStringToBytes();
                                            toPatch = patch.EndianSwapp().HexStringToBytes();
                                            for (int i = 0; i < files.Length; i++) {
                                                if (File.Exists(files[i])) {
                                                    if (IsElfDecrypted(files[i])) {
                                                        List<long> offsets = new List<long>();
                                                        status.Text = "Working on File: " + files[i].GetName() + "...";
                                                        FileInfo fileInfo = new FileInfo(files[i]);

                                                        using (BinaryReader br = new BinaryReader(new FileStream(files[i], FileMode.Open, FileAccess.Read))) {
                                                            while (true) {
                                                                status.Text = "Seeking...";
                                                                br.BaseStream.Seek(offset, SeekOrigin.Begin);
                                                                br.Read(check, 0, 4);
                                                                if (check.Contains(toLookup)) {
                                                                    status.Text = "Found a FW string...";
                                                                    offsets.Add(offset);
                                                                    status.Text = "Found a FW string...added !";
                                                                }
                                                                offset += 1;
                                                                if (offset == fileInfo.Length) break;
                                                            }
                                                            br.Close();

                                                            int count = offsets.Count;
                                                            if (count > 0) {
                                                                using (BinaryWriter bw = new BinaryWriter(new FileStream(files[i], FileMode.Open, FileAccess.Write))) {
                                                                    long[] _offsets = offsets.ToArray();
                                                                    foreach (long _offset in _offsets) {
                                                                        status.Text = "Patching " + (patched + 1).ToString() + " of " + count.ToString() + "FW Strings...";
                                                                        bw.BaseStream.Seek(_offset, SeekOrigin.Begin);
                                                                        bw.Write(toPatch, 0, 4);
                                                                        patched++;
                                                                    }
                                                                    bw.Close();
                                                                    status.Text = "Patching...done !";
                                                                }
                                                            }

                                                        }
                                                    } else MessageBox.Show("File is either, not decrypted or not an ELF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                } else MessageBox.Show("Can't access the file on this point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                progressBar.PerformStep();
                                            }
                                        } catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;  }
                                        finally { MessageBox.Show("Patched " + patched.ToString() + " FW versions in " + files.Length.ToString() + " files."); }
                                    } else MessageBox.Show("No Files selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else MessageBox.Show("FW to Patch is not a Hex value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else MessageBox.Show("FW to Lookup is not a Hex value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else MessageBox.Show("FW to Patch is to short.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else MessageBox.Show("FW to Lookup is to short.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else MessageBox.Show("FW to Patch hase no value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("FW to Lookup hase no value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
