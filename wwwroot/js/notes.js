// Note boards
(() => {
  document.querySelectorAll(".note-board").forEach((board) => {
    const note = board.querySelector(".note");
    const body = board.querySelector(".note-body");
    const metaEl = board.querySelector("[data-note-meta]");
    const textEl = board.querySelector("[data-note-text]");
    const tiles = board.querySelectorAll(".tile");
    if (!note || !body || !metaEl || !textEl) return;

    const defaultText = textEl.textContent;

    const pop = () => {
      body.classList.remove("pop");
      void body.offsetWidth; // Restart
      body.classList.add("pop");
    };

    tiles.forEach((tile) => {
      tile.addEventListener("click", () => {
        const wasActive = tile.classList.contains("active");

        tiles.forEach((t) => {
          t.classList.remove("active");
          t.setAttribute("aria-pressed", "false");
        });

        if (wasActive) {
          note.classList.remove("is-reading");
          metaEl.textContent = "";
          textEl.textContent = defaultText;
        } else {
          tile.classList.add("active");
          tile.setAttribute("aria-pressed", "true");
          note.classList.add("is-reading");
          metaEl.textContent = tile.dataset.meta || "";
          textEl.textContent = tile.dataset.text || "";
        }

        pop();

        // Scroll
        if (window.matchMedia("(max-width: 760px)").matches) {
          body.scrollIntoView({ behavior: "smooth", block: "center" });
        }
      });
    });
  });
})();
