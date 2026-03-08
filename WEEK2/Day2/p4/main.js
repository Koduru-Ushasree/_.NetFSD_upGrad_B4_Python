import {
    addTaskAsync,
    deleteTaskAsync,
    listTasksAsync
} from './taskManager.js';

const input = document.getElementById("taskInput");
const output = document.getElementById("output");
// Add Task (Async/Await)
document.getElementById("addBtn").addEventListener("click", async () => {
    const task = input.value.trim();
    if (!task) return;

    const message = await addTaskAsync(task);
    output.innerHTML = `<p>${message}</p>`;
    input.value = "";
});
// Delete Task
document.getElementById("deleteBtn").addEventListener("click", async () => {
    const task = input.value.trim();
    if (!task) return;

    const message = await deleteTaskAsync(task);
    output.innerHTML = `<p>${message}</p>`;
    input.value = "";
});
// List Tasks
document.getElementById("listBtn").addEventListener("click", async () => {
    const message = await listTasksAsync();
    output.innerHTML = `<p>${message}</p>`;
});