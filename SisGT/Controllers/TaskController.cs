using SisGT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SisGT.Controllers
{
    internal class TaskController
    {
        private readonly string DirectoryPath = @"c:\Temp";
        private readonly string DataPath = @"c:\Temp\dataTask.txt";
        internal List<TaskModel> Tasks { get; set; }

        internal bool Create(TaskModel task)
        {
            try
            {
                Read();

                if (Tasks.Count <= 0)
                {
                    task.Id = 1;
                    Tasks.Add(task);

                    File.WriteAllText(DataPath, JsonSerializer.Serialize(Tasks));
                }
                else
                {
                    task.Id = Tasks.Last().Id + 1;
                    Tasks.Add(task);
                    
                    File.WriteAllText(DataPath, JsonSerializer.Serialize(Tasks));
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            return false;
        }

        internal List<TaskModel> Read()
        {
            try
            {
                Tasks = new List<TaskModel>();

                if (!Directory.Exists(DirectoryPath))
                {
                    Directory.CreateDirectory(DirectoryPath);
                    if (!File.Exists(DataPath))
                        File.Create(DataPath).Close();
                    return Tasks;
                }
                else
                {
                    StreamReader dataReader = new StreamReader(DataPath);
                    
                    string tasks = dataReader.ReadToEnd().Trim();
                    Tasks = !string.IsNullOrWhiteSpace(tasks) ? JsonSerializer.Deserialize<List<TaskModel>>(tasks) : new List<TaskModel>();
                    
                    dataReader.Close();

                    return Tasks;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return new List<TaskModel>();
            }
        }

        internal TaskModel ReadId(int id = 0)
        {
            try
            {
                Read();

                if (Tasks.Count > 0 && id != 0)
                {
                    int count = 0;
                    while (Tasks[count].Id != id && count < Tasks.Count)
                        count++;

                    return count != Tasks.Count ? Tasks[count] : new TaskModel();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            return new TaskModel();
        }

        internal bool Update(TaskModel task, int id = 0)
        {
            try
            {
                Read();

                if (Tasks.Count > 0 && id != 0)
                {
                    int count = 0;
                    while (Tasks[count].Id != id && count < Tasks.Count) count++;

                    if (Tasks[count].Id == id)
                    {
                        Tasks[count].Title = task.Title;
                        Tasks[count].Description = task.Description;
                        Tasks[count].Status = task.Status;

                        File.WriteAllText(DataPath, JsonSerializer.Serialize(Tasks));

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            return false;
        }

        internal bool Delete(int id)
        {
            try
            {
                Read();

                if (Tasks.Count > 0 && id != 0)
                {
                    int count = 0;
                    while (Tasks[count].Id != id && count < Tasks.Count) count++;

                    if (Tasks[count].Id == id)
                    {
                        Tasks.RemoveAt(count);

                        File.WriteAllText(DataPath, JsonSerializer.Serialize(Tasks));

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            return false;
        }
    }
}
