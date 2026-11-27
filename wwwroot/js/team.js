// Team picker
(() => {
  const roster = document.querySelector(".roster");
  const button = document.getElementById("roster-toggle");
  if (!roster || !button) return;

  button.addEventListener("click", () => {
    const isOpen = roster.classList.toggle("is-open");
    button.setAttribute("aria-expanded", String(isOpen));
    button.textContent = isOpen ? "Hide the team" : "Meet the team";
  });
})();
