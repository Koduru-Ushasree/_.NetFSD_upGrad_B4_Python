// Global task storage
let tasks = [];
//callback
export const addTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task);
        callback(`(Callback) Task "${task}" added.`);
    }, 1000);
};
//Promise
export const addTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(`(Promise) Task "${task}" added.`);
        }, 1000);
    });
};
//Async/Await
export const addTaskAsync = async (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(`(Async/Await) Task "${task}" added.`);
        }, 1000);
    });
};

export const deleteTaskAsync = async (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks = tasks.filter(t => t !== task);
            resolve(`Task "${task}" deleted.`);
        }, 1000);
    });
};

export const listTasksAsync = async () => {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(`Current Tasks: ${tasks.join(", ") || "No tasks"}`);
        }, 500);
    });
};