// SPDX-FileCopyrightText: 2025 Space Station 14 Contributors
//
// SPDX-License-Identifier: MIT-WIZARDS

namespace Content.Shared.Beeper;
[ByRefEvent]
public record struct BeepPlayedEvent(bool Muted);
