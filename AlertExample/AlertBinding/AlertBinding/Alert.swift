//
//  Alert.swift
//  AlertBinding
//
//  Created by Teo on 2022/09/13.
//

import Foundation
import AppKit;

@objc(AlertTesterProxy)
public class AlertTesterProxy : NSObject {
    
    @objc
    public func errorReadingResults(question: String, text: String) -> Bool {
        let alert = NSAlert()
        alert.messageText = question
        alert.informativeText = text
        alert.addButton(withTitle: "OK")
        alert.addButton(withTitle: "Cancel")
        return alert.runModal() == NSApplication.ModalResponse.alertFirstButtonReturn
    }
}
