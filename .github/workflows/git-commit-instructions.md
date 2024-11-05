
# Git Commit Message Guidelines

This file provides custom instructions for writing consistent and informative Git commit messages for the **Generic CRUD Application with Client and Component Libraries** project.

## Commit Message Structure

Each commit message should follow this format:

```
<type>: <short description>

[Optional body]

[Optional footer]
```

### 1. Commit Types

Use the following types to categorize your commits:

- **feat**: A new feature for the application (e.g., "feat: Add Create and Update operations for Item entity").
- **fix**: A bug fix (e.g., "fix: Correct null reference error in ItemService").
- **refactor**: Code changes that neither fix a bug nor add a feature (e.g., "refactor: Simplify RepositoryBase<T> logic").
- **docs**: Documentation updates (e.g., "docs: Update README with setup instructions").
- **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc.).
- **test**: Adding or updating tests (e.g., "test: Add unit tests for ItemService").
- **chore**: Routine tasks, such as updating dependencies or configuration (e.g., "chore: Update Entity Framework version").

### 2. Short Description

The short description should:

- Use the **imperative mood** (e.g., "Add", "Fix", "Update").
- Be **50 characters or less** for clarity.
- Clearly state **what was done** without too much detail (e.g., "feat: Implement base CRUD operations for entities").

### 3. Commit Body (Optional)

Include a body if the commit requires additional context. For example:

- **Why** a change was made.
- **How** a fix was implemented.
- Any **dependencies or prerequisites** for this change.

Example:
```
feat: Implement base CRUD operations for entities

Added Add, Update, Delete, and Get methods in RepositoryBase<T>.
This change supports consistent CRUD operations across all entities.
```

### 4. Commit Footer (Optional)

Use the footer to reference issue numbers or pull requests. For example:

```
fix: Correct null reference error in ItemService

Closes #42
```

### Examples

Here are examples of well-structured commit messages for this project:

- `feat: Add new Blazor component for CRUD operations`
- `fix: Resolve API error in dependency injection setup`
- `docs: Add instructions for configuring GitHub Copilot`
- `refactor: Move Entity Framework configuration to Program.cs`
- `test: Add integration tests for Client-API communication`

---

### Summary

By following these commit message guidelines, you’ll ensure that the commit history is:

- **Clear**: Easy to understand what each commit changes.
- **Consistent**: Follows a standard structure for readability.
- **Traceable**: Connects commits to relevant issues or pull requests when applicable.

These guidelines make it easier to track the evolution of the project and understand the purpose of each change.
