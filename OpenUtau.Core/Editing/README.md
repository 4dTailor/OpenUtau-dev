# Batch Edit Macros

Contributions to editing macros are welcomed.
            
A batch edit should: 
- Use a translatable key stored in `OpenUtau/Strings/Strings.axaml`
- Performs modifications by calling `docManager.ExecuteCmd();` with commands.
  - Some commands come with a single note variation and a multiple notes variation, e.g., `AddNoteCommand(UVoicePart part, UNote note)` and `AddNoteCommand(UVoicePart part, List<UNote> notes)`. Use the multiple notes varitaion for batch edits.
- Has a localized name.
- Have implementations of the batch edit either:
  - Start with `docManager.StartUndoGroup();` and end with `docManager.EndUndoGroup();`, or
  - Be inside `docManager.ExecuteWithinUndoGroup`, using `edit.Name` as the key.
